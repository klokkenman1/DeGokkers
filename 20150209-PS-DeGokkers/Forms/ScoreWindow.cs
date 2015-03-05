using DeGokkers.Classes;
using DeGokkers.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers.Forms
{
    public partial class ScoreWindow : Form
    {

        public ScoreWindow()
        {
            InitializeComponent();
        }

        public ScoreWindow(Animal[] finished)
            :this()
        {
            int yPos = 0;
            for (int i = 0; i < finished.Length; i++)
            {
                FinishedAnimal fa = new FinishedAnimal(i + 1, finished[i]);
                fa.Location = new Point(0, yPos);

                pnlAnimals.Controls.Add(fa);
                yPos += fa.Height;
            }
        }

        private void ScoreWindow_Load(object sender, EventArgs e)
        {
        }
    }
}
