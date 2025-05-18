using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Player
    {
        public string Name {  get; set; }
        public int Scores {  get; set; }

        public Player(string name, int scores)
        {
            Name = name;
            Scores = scores;
        }
    }
}
