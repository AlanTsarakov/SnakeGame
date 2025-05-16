using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Snake
    {
        int SideSize;
        List<Sprite> snakes = new List<Sprite>();
        Form form;
        protected SnakeDirection snakeDirection = SnakeDirection.Left;
        public Snake(Form form, int SnakeLength, int SideSize, int x = 100, int y = 100)
        {
            this.form = form;
            this.SideSize = SideSize;
            for (int i = 0; i < SnakeLength; i++)
            {
                snakes.Add(new Sprite(form, SideSize, x + SideSize*i, y + SideSize, true));
            }
            
        }

        public bool CheckFoodCollision(Food food)
        {
            
            foreach (var item in snakes)
            {
                if (item.Location == food.Location)
                    return true;
            }
            return false;
        }

        public bool CheckTailCollision()
        {
            HashSet<Point> set = new HashSet<Point>();
            for (int i = 0; i < snakes.Count; i++)
            {
                set.Add(snakes[i].Location);
            }
            return !(set.Count == snakes.Count);
        }

        public void Grow()
        {
            snakes.Add(new Sprite(form, SideSize, -SideSize, -SideSize, true));


        }

        internal void Clear()
        {
            form.Controls.Clear();
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



            Point[] positions = new Point[snakes.Count];
            for (int i = 0; i < snakes.Count-1; i++)
            {
                positions[i] = snakes[i].Location;
            }

            if (snakeDirection == SnakeDirection.Down)
            {
                snakes[0].Y += SideSize;
            }
            else if (snakeDirection == SnakeDirection.Up)
            {
                snakes[0].Y -= SideSize;
            }
            else if (snakeDirection == SnakeDirection.Right)
            {
                snakes[0].X += SideSize;
            }
            else if (snakeDirection == SnakeDirection.Left)
            {
                snakes[0].X -= SideSize;
            }

            for (int i = 1; i < snakes.Count; i++)
            {
                snakes[i].X = positions[i - 1].X;
                snakes[i].Y = positions[i - 1].Y;
            }

        }
    }
}
