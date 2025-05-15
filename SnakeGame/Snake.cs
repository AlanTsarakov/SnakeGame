using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Snake : Sprite
    {

        int SnakeLength = 10;
        Sprite head;
        List<Sprite> snakes = new List<Sprite>();
        protected SnakeDirection snakeDirection = SnakeDirection.Right;
        public Snake(Form form, Sprite sprite, int SnakeLength) : base(form, sideSize:10, x:10, y:10, draw: true)
        {
            this.SnakeLength = SnakeLength;
            for (int i = 0; i < SnakeLength; i++)
            {
                snakes.Add(new Sprite(form, 10, 10*i, 10, true));
                head = sprite;
                segments.Add(new Point(10*i, 10));
            }
            
        }
        
        public enum SnakeDirection
        {
            Left,
            Right,
            Up,
            Down
        }
        public SnakeDirection GetSnakeDirection()
        {
            return snakeDirection;
        }
        public void SetSnakeDirection(SnakeDirection direction)
        {
            snakeDirection = direction;
        }

        public void MoveSnake()
        {
            
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
