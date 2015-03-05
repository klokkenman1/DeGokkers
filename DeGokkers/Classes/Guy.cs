using DeGokkers.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers
{
    public class Guy
    {
        private string name;
        private Bet bet;
        private int cash;

        public Guy(string name, int cash)
        {
            this.name = name;
            this.cash = cash;
            this.bet = new Bet(0, null, this);
        }

        public bool PlaceBet(int amount, Animal animal)
        {
            // Return true if the "Guy" has enough cash to place the bet
            if ((cash - amount) >= 0)
            {
                // Place bet in bet variable with this Guy as bettor.
                this.bet.SetAmount(amount);
                this.bet.SetAnimal(animal);

                return true;
            }
            return false;
        }

        public void ClearBet()
        {
            this.bet = null;
        }

        public void AddCash(int amount)
        {
            cash += amount;
        }

        public int GetCash()
        {
            return cash;
        }

        public void SetCash(int amount)
        {
            cash = amount;
        }

        public string GetName()
        {
            return name;
        }

        public Bet GetBet()
        {
            return this.bet;
        }
    }
}
