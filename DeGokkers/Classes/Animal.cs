using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers.Classes
{
    abstract public class Animal
    {
        private string type;
        private Bitmap resource;

        public int moveSpeed;
        protected int amount;
        private string name;
        protected int raceTrackPosition;
        protected PictureBox pictureBox;
        protected Random random;
        protected int number;
        protected Label lbl;
        public Size animalSize;

        public abstract bool Run();

        public override string ToString()
        {
            return name;
        }

        public Animal(string type, Bitmap resource)
        {
            this.type = type;
            this.resource = resource;
        }

        public Animal(string name, PictureBox pictureBox)
        {
            this.name = name;
            this.pictureBox = pictureBox;
            this.pictureBox.BackgroundImage = null; 
            this.pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.moveSpeed = 10;

            // Create instance of random number generator.
            random = new Random();
        }

        public abstract Animal CreateAnimal(int index, Racetrack raceTrack, PictureBox pictureBox);
        public abstract bool TakeStartingPosition();
        public abstract Bitmap GetRacetrackImage();

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public string GetAnimalType()
        {
            return type;
        }

        public Bitmap GetResource()
        {
            return resource;
        }

        public string GetName()
        {
            return name;
        }

        public int GetCount()
        {
            return amount;
        }

        public void SetCount(int amount)
        {
            this.amount = amount;
        }

        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }

        public void SetNameLabel(Label lblDog)
        {
            this.lbl = lblDog;
        }

        public Label GetNameLabel()
        {
            return lbl;
        }
    }
}
