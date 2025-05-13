using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Snake : PictureBox
    {
        private SnakeDirection snakeDirection = SnakeDirection.Up;
        int SideSize;
        int x, y;
        public Snake(Form form, int sideSize, int x, int y) 
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Square.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            SideSize = sideSize;
            this.Width = SideSize;
            this.Height = SideSize;
            form.Controls.Add(this);
            this.x = x;
            this.y = y;
            this.Location = new Point(x, y);


           
        }
        public enum SnakeDirection
        {
            Left,
            Right,
            Up,
            Down
        }
        private SnakeDirection GetSnakeDirection()
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
        }
    }
}
