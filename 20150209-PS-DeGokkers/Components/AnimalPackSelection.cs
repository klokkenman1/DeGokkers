using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeGokkers.Classes;

namespace DeGokkers.Components
{
    public partial class AnimalPackSelection : UserControl
    {
        private Animal animal;

        // Hide this constructor.
        private AnimalPackSelection()
        {
            InitializeComponent();
        }

        public AnimalPackSelection(Animal animal) : this()
        {
            this.animal = animal;
        }

        public RadioButton GetRadioButton()
        {
            return rndSelect;
        }

        public Animal GetAnimal()
        {
            return animal;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.BackgroundImage = animal.GetResource();

            // Call the base class OnLoad to ensure any delegate event handlers are still callled
            base.OnLoad(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // TODO: Perhaps draw an outline here or something.
            //Rectangle rect = new Rectangle(5, 5, this.Width, this.Height);
            //e.Graphics.DrawLine(new Pen(Color.Green, 10f), new Point(0, 0), new Point(this.Width, this.Height));

            base.OnPaint(e);
        }
    }
}
