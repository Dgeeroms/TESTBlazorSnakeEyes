using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Dice
    {
        private Random _randomizer;

        public int Dots { get; set; }

        public Dice()
        {
            _randomizer = new Random();
            Dots = 6;
        }

        public void Roll()
        {
            Dots = _randomizer.Next(1, 7);
        }
    }
}
