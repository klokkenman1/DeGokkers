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
    public partial class BetEntry : UserControl
    {
        private int[] betValues;
        private Guy guy;

        private BetEntry()
        {
            InitializeComponent();
        }

        public BetEntry(int minBet, int maxBet, Guy guy, List<Animal> animals) : this()
        {
            int[] betValues = new int[maxBet - minBet + 1];
            int count = 0;
            this.guy = guy;

            for (int i = minBet; i <= maxBet; i++)
            {
                if (i <= guy.GetCash())
                {
                    betValues[count] = i;
                }
                count++;
            }

            lblName.Text = guy.GetName();
            lblCash.Text = "$" + guy.GetCash().ToString();

            foreach (Animal animal in animals)
            {
                lstAnimal.Items.Add(animal);
            }
            lstAnimal.SelectedIndex = 0;
            this.betValues = betValues;
        }

        private void BetEntry_Load(object sender, EventArgs e)
        {
            lstAmount.Items.Clear();

            foreach (int betValue in betValues)
            {
                lstAmount.Items.Add(betValue);
            }
            lstAmount.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstAmount.SelectedItem != null)
            {
                if (guy.PlaceBet((int)lstAmount.SelectedItem, (Animal)lstAnimal.SelectedItem))
                {

                    this.Controls.Clear();
                    DrawDescription(guy.GetBet());
                }
                else
                {
                    MessageBox.Show("You do not have enough MONEYZ!");
                }
            }
            else
            {
                MessageBox.Show("Invalid betting amount.");
            }
        }

        private void DrawDescription(Bet bet)
        {
            Label newLabel = new Label();
            newLabel.Text = bet.GetDescription();
            newLabel.Location = new Point(10, 10);
            newLabel.AutoSize = true;

            this.Controls.Add(newLabel);
        }

        private void CloseBetting()
        {
            Label newLabel = new Label();
            newLabel.Text = guy.GetName() + " heeft niet gewedt deze ronde";
            newLabel.Location = new Point(10, 10);
            newLabel.AutoSize = true;

            this.Controls.Add(newLabel);
        }
    }
}
