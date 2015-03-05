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
    public partial class FinishedAnimal : UserControl
    {
        public FinishedAnimal()
        {
            InitializeComponent();
        }
        public FinishedAnimal(int place, Animal animal)
            :this()
        {
            lblPlace.Text = place.ToString();
            lblName.Text = animal.GetName();
        }
    }
}
