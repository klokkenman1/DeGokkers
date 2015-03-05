using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeGokkers.Classes;

namespace DeGokkers
{
    public class Bet
    {
        public const int MIN_BET = 5;
        public const int MAX_BET = 15;

        private int amount;
        private Animal animal;
        private Guy bettor;

        public Bet(int amount, Animal animal, Guy bettor)
        {
            this.amount = amount;
            this.animal = animal;
            this.bettor = bettor;
        }

        public string GetDescription()
        {
            if (amount > 0)
            {
                return String.Format(LangResource.GetTranslation("format_x_bets_y_on_z"), bettor.GetName(), amount, animal.GetName());
            }
            else
            {
                return String.Format(LangResource.GetTranslation("format_x_no_bet"), bettor.GetName());
            }
        }

        public int PayOut(Animal winner)
        {
            if (winner == animal)
            {
                return amount;
            }
            else
            {
                return -amount;
            }
        }

        public void SetAmount(int amount)
        {
            this.amount = amount;
        }

        public void SetAnimal(Animal animal)
        {
            this.animal = animal;
        }
    }
}
