using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeGokkers.Classes;
using DeGokkers.Components;

namespace DeGokkers.Forms
{
    public partial class MainWindow : Form
    {
        private Racetrack raceTrack = null;

        public MainWindow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.raceTrack = new Racetrack(pctTrack);           
        }

        public void ResetGuys(Guy[] guys)
        {
            foreach (Guy guy in guys)
            {
                this.raceTrack.AddGuy(guy);
            }
        }

        public void ResetAnimals(Animal animal)
        {
            pctTrack.Image = animal.GetRacetrackImage();
            for (int i = 0; i < animal.GetCount(); i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Dock = DockStyle.None;
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                

                Animal anim = animal.CreateAnimal(i, this.raceTrack.GetLength(), pictureBox);
                this.raceTrack.AddAnimal(anim);

                Label lblDog = new Label();
                lblDog.Text =  (i + 1).ToString();
                anim.SetNameLabel(lblDog);
            }
        }

        public void ResetStartCash(int amount)
        {
            foreach (Guy guy in this.raceTrack.GetGuys())
            {
                guy.SetCash(amount);
            }
        }

        public void ResetBetting()
        {
            pnlBets.Controls.Clear();
            List<Guy> guys = raceTrack.GetGuys();
            int count = 0;
            foreach (Guy guy in guys)
            {
                BetEntry control = new BetEntry(Bet.MIN_BET, Bet.MAX_BET, guy, raceTrack.GetAnimals());
                control.Location = new Point(control.Location.X, control.Height * count);
                pnlBets.Controls.Add(control);
                guy.GetBet().SetAmount(0);
                guy.GetBet().SetAnimal(null);

                count++;
            }
        }

        public void CloseBetting()
        {
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            do
            {
                UserWindow userWindow = new UserWindow(this);
                userWindow.ShowDialog();

                if (this.raceTrack.GetGuys().Count <= 0)
                {
                    DialogResult dialogResult = MessageBox.Show(this, "Do you want to quit?", "Closing De Gokkers", MessageBoxButtons.OKCancel);

                    if (dialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        Application.Exit();
                        return;
                    }
                }
            } while (this.raceTrack.GetGuys().Count <= 0);

            raceTrack.StartPos();
        }

        private void startRace_Click(object sender, EventArgs e)
        {
            startRace.Enabled = false;
            raceTrack.StartRace();
            ResetBetting();
            raceTrack.WalkDogsBackToStart();
            startRace.Enabled = true;
        }
    }
}
