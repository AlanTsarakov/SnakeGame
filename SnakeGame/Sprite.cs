using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Sprite : PictureBox
    {
        
        protected int SideSize;

        protected int x, y;
        protected List<Point> segments = new List<Point>();

        protected Form form;
        public Sprite(Form form, int sideSize, int x, int y, bool draw = false) 
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Square.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            SideSize = sideSize;
            this.Width = SideSize;
            this.Height = SideSize;
            this.form = form;
            if (draw)
            {
                form.Controls.Add(this);
            }
            this.x = x;
            this.y = y;
            this.Location = new Point(x, y);
            
        }
        
        
     
        
    }
}
