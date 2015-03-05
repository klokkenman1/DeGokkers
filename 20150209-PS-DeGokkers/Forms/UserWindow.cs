using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeGokkers.Components;
using DeGokkers.Forms;
using DeGokkers.Interfaces;

namespace DeGokkers
{
    public partial class UserWindow : Form, UserAddRemove
    {
        private readonly int[] VALID_STARTVALUES = new int[]{
            100,
            500,
            1000,
            2500
        };

        private List<UserEntry> userEntries;

        public UserWindow()
        {
            InitializeComponent();

            userEntries = new List<UserEntry>();

            // Create the default amount of players.
            for (int i = 0; i < Racetrack.DEFAULT_PLAYERS; i++)
            {
                OnUserAdd();
            }

            for (int i = 0; i < VALID_STARTVALUES.Length; i++)
            {
                comboStartCash.Items.Add(VALID_STARTVALUES[i]);
            }
        }

        public void OnUserAdd()
        {
            if (userEntries.Count < Racetrack.MAX_PLAYERS)
            {
                UserEntry userEntry = new UserEntry();
                userEntry.SetControlWindow(this);
                userEntries.Add(userEntry);
                pnlPlayers.Controls.Add(userEntry);
                userEntry.Location = new Point(userEntry.Location.X, userEntry.Location.Y + (userEntry.Size.Height * (userEntries.Count - 1)));
            }
            else
            {
                MessageBox.Show("Maximum aantal spelers bereikt!");
            }
        }

        public void OnUserRemove()
        {
            if (userEntries.Count > Racetrack.MIN_PLAYERS)
            {
                UserEntry userEntry = userEntries[userEntries.Count - 1];

                pnlPlayers.Controls.Remove(userEntry);
                userEntries.Remove(userEntry);
            }
            else
            {
                MessageBox.Show("Minimum aantal spelers bereikt!");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(comboStartCash.Text);

            if (comboStartCash.Items.Contains(value))
            {
                Guy[] guys = new Guy[userEntries.Count];

                for (int i = 0; i < userEntries.Count; i++)
                {
                    guys[i] = new Guy(userEntries[i].GetValue(), value);
                }

                MainWindow mainWindow = new MainWindow(guys);
            }
        }
    }
}
