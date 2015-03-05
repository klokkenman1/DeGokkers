using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeGokkers.Classes;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using DeGokkers.Forms;

namespace DeGokkers
{
    public class Racetrack
    {
        public const int MIN_PLAYERS = 3;
        public const int MAX_PLAYERS = 15;
        public const int DEFAULT_PLAYERS = 3;
        public int Xpos = 1;
        public int Ypos = 1;


        private int raceTrackLength = 600;
        private int raceTrackHeight;
        private List<Animal> animals;
        private List<Guy> bettors;
        private PictureBox track;

        public Racetrack(PictureBox track)
        {
            this.animals = new List<Animal>();
            this.bettors = new List<Guy>();
            this.track = track;
            track.Image = Properties.Resources.background_dogtrackpng;

            raceTrackHeight = track.Size.Height;
        }

        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }

        public void AddGuy(Guy bettor)
        {
            this.bettors.Add(bettor);
        }

        public int GetLength()
        {
            return raceTrackLength;
        }

        public List<Guy> GetGuys()
        {
            return bettors;
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public void StartPos()
        {
            foreach (Animal animal in this.animals)
            {
                animal.TakeStartingPosition();
                PictureBox p = animal.GetPictureBox();
                Label lbl = animal.GetNameLabel();
                double aspectRatio = animal.animalSize.Width / animal.animalSize.Height;
                int animalHeight = track.Height / animals.Count;
                p.Size = new Size((int)(animalHeight * aspectRatio), animalHeight);

                track.Controls.Add(p);
                lbl.Location = new Point(10, 12);
                p.Controls.Add(lbl);
                p.Location = new Point(Xpos, Ypos);

                Ypos += track.Height / animals.Count;
            }
        }

        Animal[] finishedAnimals;
        int count = 0;

        public int GetFinishedAnimalCount()
        {
            return finishedAnimals.Length;
        }
        Random rnd = new Random();

        public bool Update()
        {
            List<int> availableAnimals = new List<int>();

            for (int i = 0; i < animals.Count; i++)
			{
                availableAnimals.Add(i);
			}

            while (availableAnimals.Count > 0)
            {
                int temp = rnd.Next(0 ,availableAnimals.Count);
                if (!finishedAnimals.Contains(animals[availableAnimals[temp]]) && animals[availableAnimals[temp]].Run())
                {
                    finishedAnimals[count++] = animals[availableAnimals[temp]];
                }
                availableAnimals.Remove(availableAnimals[temp]);
            }

            if (count < this.animals.Count)
            {
                return false;
            }

            return true;
        }

        public void StartRace()
        {
            finishedAnimals = new Animal[this.animals.Count];
            count = 0;
        }

        public void EndRace()
        {
            ScoreWindow scoreWindow = new ScoreWindow(finishedAnimals);
            scoreWindow.ShowDialog();

            string winners = "";

            foreach (Guy bettor in this.bettors)
            {
                Bet bet = bettor.GetBet();
                int moneyModifier = bet.PayOut(finishedAnimals[0]);
                bettor.AddCash(moneyModifier);
                if (moneyModifier > 0)
                {
                    winners += bettor.GetName() + ", ";
                }
            }
            if (winners == "")
            {
                MessageBox.Show("There are no winners");
            }
            else
            {
                MessageBox.Show("The winners are: " + winners);
            }
        }


        public void WalkDogsBackToStart()
        {
            Animal[] dogsAtStart = new Animal[this.animals.Count];
            int dogsAtStartCount = 0;

            // Turn all animals around.
            foreach (Animal animal in this.animals)
            {
                Image img = animal.GetPictureBox().Image;
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                animal.GetPictureBox().Image = img;
            }

            while (dogsAtStartCount < this.animals.Count)
            {
                foreach (Animal animal in this.animals)
                {
                    if (!dogsAtStart.Contains(animal) && animal.TakeStartingPosition())
                    {
                        dogsAtStart[dogsAtStartCount++] = animal;
                    }
                }
            }

            // Turn all animals back around.
            foreach (Animal animal in this.animals)
            {
                Image img = animal.GetPictureBox().Image;
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                animal.GetPictureBox().Image = img;
            }
        }
        public PictureBox GetPicturebox()
        {
            return track;
        }
    }
}
