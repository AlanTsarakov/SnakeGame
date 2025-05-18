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
        public Food(Form form) : base(form, sideSize: 20, x: 20, y: 20, true)
        {
            this.Location = new System.Drawing.Point(rnd.Next(0, 10)*SideSize, rnd.Next(0, 10)*SideSize);
        }

        public void MoveFood()
        {
            this.Location = new System.Drawing.Point(rnd.Next(0, 20) * SideSize, rnd.Next(0, 20) * SideSize);
        }
    }
}
