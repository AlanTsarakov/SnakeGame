using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class GameController : Snake
    {

        int SnakeLength = 100;
        Snake head;
        List<Snake> snakes = new List<Snake>();
        public GameController(Form form, Snake snake): base(form, sideSize:10, x:10, y:10)
        {
            
            for (int i = 0; i < SnakeLength; i++)
            {
                snakes.Add(new Snake(form, 10, 10*i, 10));
                head = snake;
                segments.Add(new Point(10, 10 * i));
            }
            
        }
        public void MoveSnake()
        {
            snakeDirection = head.GetSnakeDirection();
            if (snakeDirection == SnakeDirection.Down)
            {
                y += SideSize;
            }
            else if (snakeDirection == SnakeDirection.Up)
            {
                y -= SideSize;
            }
            else if (snakeDirection == SnakeDirection.Right)
            {
                x += SideSize;
            }
            else if (snakeDirection == SnakeDirection.Left)
            {
                x -= SideSize;
            }
            this.Location = new Point(x, y);
            segments.Add(Location);

            for (int i = 0; i < SnakeLength; i++)
            {
                snakes[snakes.Count - i -1 ].Location = segments[segments.Count - i -1];
            }


        }
    }
}
