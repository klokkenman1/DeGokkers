﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeGokkers.Classes;
using DeGokkers.Forms;

namespace DeGokkers
{
    public class Greyhound : Animal
    {
        List<String> houndName = new List<String>();
        private new Random random = new Random();
        private int animalCycle = 0;
        private List<Bitmap> animalResourcesIdle = new List<Bitmap>(new Bitmap[]{
            Properties.Resources.dog2_still,
            Properties.Resources.dog3_still,
            Properties.Resources.dog4_still,
        });
        private List<Bitmap> animalResourcesRunning = new List<Bitmap>(new Bitmap[]{
            Properties.Resources.dog2,
            Properties.Resources.dog3,
            Properties.Resources.dog4,
        });

        public Greyhound(string type, Bitmap resource)
            : base(type, resource)
        {
            amount = 4;
            houndName.Add("Phoebe");
            houndName.Add("Atlas");
            houndName.Add("Aura");
            houndName.Add("Selene");
            houndName.Add("Helios");
            houndName.Add("Asteria");
            houndName.Add("Styx");
            houndName.Add("Leto");
            houndName.Add("Metis");
            houndName.Add("Nephilim");
        }

        public Greyhound(string name, int raceTrackLength, PictureBox pictureBox)
            : base(name, raceTrackLength, pictureBox)
        {
            amount = 4;           
        }

        public override Animal CreateAnimal(int index, int raceTrackLength, PictureBox pictureBox)
        {   
            string animalName = houndName[random.Next(0, houndName.Count)];
            string getName = String.Format("#{0} - {1}", index + 1, animalName);
            houndName.Remove(animalName);
            
            Greyhound newGreyhound = new Greyhound(getName, raceTrackLength, pictureBox);
            newGreyhound.SetImageID(animalCycle);
            newGreyhound.SetNumber(index + 1);
            PictureBox ghPictureBox = newGreyhound.GetPictureBox();
            ghPictureBox.BackColor = Color.Transparent;
            ghPictureBox.Dock = DockStyle.None;
            ghPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ghPictureBox.Size = new Size(100, 50);
            ghPictureBox.Image = animalResourcesIdle[animalCycle++];

            if (animalCycle >= animalResourcesRunning.Count)
            {
                animalCycle = 0;
            }

            return newGreyhound;
        }

        private int imageID;

        public void SetImageID(int id)
        {
            imageID = id;
        }

        private bool isRunning = false;

        // Method that makes the animal run from 1 - 4 positions.
        public override bool Run()
        {
            if (!isRunning)
            {
                GetPictureBox().Image = animalResourcesRunning[imageID];
                isRunning = true;
            }
            // Proceed 1 - 4 positions
            // Adjust this.pictureBox on the form
            // Return true if the race is won
            Random r = new Random();
            int move = r.Next(4);
            Point p = this.pictureBox.Location;
            //System.Threading.Thread.Sleep(3);
            p.X += move;
            this.pictureBox.Location = p;

            // Cleans up after the animal so it doesnt leave a trail.
            Application.DoEvents();

            if (p.X >= raceTrackLength)
            {
                GetPictureBox().Image = animalResourcesIdle[imageID];
                isRunning = false;
                return true;
            }
            return false;
        }

        public override bool TakeStartingPosition()
        {
            Point p = this.pictureBox.Location;
            p.X -= 4;

            // Cleans up after the animal so it doesnt leave a trail.
            Application.DoEvents();

            if (p.X <= 0)
            {
                p.X = 0;
                this.pictureBox.Location = p;
                return true;
            }

            this.pictureBox.Location = p;
            return false;
        }

        public override Bitmap GetRacetrackImage()
        {
            return Properties.Resources.background_dogtrackpng;
        }

    }
}
