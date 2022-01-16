using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Game
    {
        private IList<int> _highscores;
        private Dice _dice1;
        private Dice _dice2;
        private bool _snakeEyes = false;

        public int Eye1 => _dice1.Dots;
        public int Eye2 => _dice2.Dots;
        public bool HasSnakeEyes => _snakeEyes;
        public IReadOnlyList<int> Highscores => (IReadOnlyList<int>) _highscores;
        public int Total { get; set; }

        public Game()
        {
            _highscores = new List<int>();
            Initialize();
        }

        private void Initialize()
        {
            _dice1 = new Dice();
            _dice2 = new Dice();
            Total = 0;
        }

        public void Play()
        {
            _dice1.Roll();
            _dice2.Roll();

            if(_dice1.Dots == 1 && _dice2.Dots == 1)
            {
                _snakeEyes = true;
                _highscores.Add(Total);
                Total = 0;
            } else
            {
                Total += _dice1.Dots + _dice2.Dots;
            }

        }

        public void Restart()
        {
            Initialize();
        }


    }
}
