using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAss3
{
    public class Dice
    {
        Random random = new Random();
        public int Value;
        public int ThrowDice(int diceNumber)
        {
           return random.Next(1,diceNumber);
        }


        public void ThrowDiceOther(int diceNumber)
        {
            Value = random.Next(1, diceNumber);
        }
        public void AddOtherDiceValue(int diceNumber) {
            Value += diceNumber; 
        }
    }
}
