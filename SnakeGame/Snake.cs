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
        protected SnakeDirection snakeDirection = SnakeDirection.Right;
        protected int SideSize;

        protected int x, y;
        protected List<Point> segments = new List<Point>();
 
        Form form;
        public Snake(Form form, int sideSize, int x, int y) 
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Square.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            SideSize = sideSize;
            this.Width = SideSize;
            this.Height = SideSize;
            this.form = form;
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
        public SnakeDirection GetSnakeDirection()
        {
            return snakeDirection;
        }
        public void SetSnakeDirection(SnakeDirection direction)
        {
            snakeDirection = direction;
        }
     
        
    }
}
