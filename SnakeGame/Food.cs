using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Food : Sprite
    {
        Random rnd = new Random();
        public Food(Form form) : base(form, sideSize: 10, x: 1, y: 1, true)
        {
            this.Location = new System.Drawing.Point(rnd.Next(0, 30)*10, rnd.Next(0, 30)*10);
        }

        public void MoveFood()
        {
            this.Location = new System.Drawing.Point(rnd.Next(0, 30) * 10, rnd.Next(0, 30) * 10);
        }
    }
}
