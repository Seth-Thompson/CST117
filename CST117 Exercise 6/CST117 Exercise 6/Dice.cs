using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Exercise_6
{
    class Dice
    {
        public int sides { get; private set; }

        public Dice(int sides)
        {
            this.sides = sides;
        }

        public void DiceRoller()
        {
            Random rnd = new Random();
            sides = rnd.Next(7);
        }
    }
}
