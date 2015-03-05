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
using DeGokkers.Forms;
using DeGokkers.Interfaces;

namespace DeGokkers
{
    public partial class UserWindow : Form, UserAddRemove
    {
        private const int ANIMAL_CARD_MARGIN = 5;
        private readonly int[] VALID_STARTVALUES = new int[]{
            20,
            100,
            500,
            1000,
            2500
        };

        private RadioButton lastSelected;
        private List<UserEntry> userEntries;
        private MainWindow parentForm;

        private UserWindow()
        {
            InitializeComponent();

            Text = LangResource.GetTranslation("title_settings_window");
            grpPlayers.Text = LangResource.GetTranslation("lbl_players");
            grpAnimals.Text = LangResource.GetTranslation("lbl_animals");
            lblPlayersEntry.Text = LangResource.GetTranslation("lbl_info_set_config");
            lblStartCash.Text = LangResource.GetTranslation("lbl_start_cash");
        }

        // Custom constructor that also calls main constructor.
        public UserWindow(MainWindow parentForm) : this()
        {
            userEntries = new List<UserEntry>();
            this.parentForm = parentForm;

            // Create the default amount of players.
            for (int i = 0; i < Racetrack.DEFAULT_PLAYERS; i++)
            {
                OnUserAdd();
            }

            // Set the values of the bets that can be placed.
            for (int i = 0; i < VALID_STARTVALUES.Length; i++)
            {
                comboStartCash.Items.Add(VALID_STARTVALUES[i]);
            }

            // Set the selection of the combobox to the first item.
            comboStartCash.SelectedIndex = 0;

            // Set the animals that can be selected from.
            Animal[] animals = new Animal[] { new Greyhound(LangResource.GetTranslation("animal_greyhound"), Properties.Resources.card_greyhound), new Ostrich(LangResource.GetTranslation("animal_ostrich"), Properties.Resources.card_ostrich) };
            int count = 0;

            List<RadioButton> btns = new List<RadioButton>();
            foreach (Animal animal in animals)
            {
                AnimalPackSelection aps = new AnimalPackSelection(animal);
                RadioButton apsRadioButton = aps.GetRadioButton();
                apsRadioButton.Tag = aps;
                btns.Add(apsRadioButton);
                pnlDogs.Controls.Add(aps);
                aps.Location = new Point(aps.Location.X + ((aps.Size.Width + ANIMAL_CARD_MARGIN) * count), aps.Location.Y);
                count++;
            }
            btns[0].Checked = true;
            lastSelected = btns[0];
            btns.ForEach(r => r.CheckedChanged += (_, __) =>
            {
                if (r.Checked) 
                {
                    btns.ForEach(rb => rb.Checked = rb == r);
                    lastSelected = r;
                }
            });
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
                MessageBox.Show(LangResource.GetTranslation("err_max_players"));
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
                MessageBox.Show(LangResource.GetTranslation("err_min_players"));
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

                Animal animal = ((AnimalPackSelection) lastSelected.Tag).GetAnimal();

                this.parentForm.ResetGuys(guys);
                this.parentForm.ResetStartCash(value);
                this.parentForm.ResetAnimals(animal);
                this.parentForm.ResetBetting();

                this.Close();
            }
            else
            {
                MessageBox.Show(LangResource.GetTranslation("err_invalid_start_money"));
            }
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
