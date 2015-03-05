using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeGokkers.Classes;

namespace DeGokkers
{
    public class Ostrich : Greyhound
    {
        private new Random random = new Random();
        private int animalCycle = 0;
        private List<String> ostrichName = new List<String>();
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

        public Ostrich(string type, Bitmap resource)
            : base(type, resource)
        {
            SetCount(5);
            ostrichName.Add("Phoebe");
            ostrichName.Add("Atlas");
            ostrichName.Add("Aura");
            ostrichName.Add("Selene");
            ostrichName.Add("Helios");
            ostrichName.Add("Asteria");
            ostrichName.Add("Styx");
            ostrichName.Add("Leto");
            ostrichName.Add("Metis");
            ostrichName.Add("Nephilim");
        }

        public Ostrich(string name, int raceTrackLength, PictureBox pictureBox)
            : base(name, raceTrackLength, pictureBox)
        {
            animalSize = new Size(100, 50);
        }

        public override Animal CreateAnimal(int index, Racetrack raceTrack, PictureBox pictureBox)
        {
            string animalName = ostrichName[random.Next(0, ostrichName.Count)];
            string getName = String.Format(LangResource.GetTranslation("format_num_x_dog_name_y"), index + 1, animalName);
            //ostrichName.Remove(animalName);

            Ostrich newOstrich = new Ostrich(getName, raceTrack.GetLength(), pictureBox);
            newOstrich.raceTrack = raceTrack;
            newOstrich.SetImageID(animalCycle);
            newOstrich.SetNumber(index + 1);
            PictureBox ghPictureBox = newOstrich.GetPictureBox();
            ghPictureBox.BackColor = Color.Transparent;
            ghPictureBox.Dock = DockStyle.None;
            ghPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ghPictureBox.Size = new Size(100, 50);
            ghPictureBox.Image = animalResourcesIdle[animalCycle++];

            if (animalCycle >= animalResourcesRunning.Count)
            {
                animalCycle = 0;
            }

            return newOstrich;
        }

        public override Bitmap GetRacetrackImage()
        {
            return Properties.Resources.background_dogtrackpng;
        }
    }
}
