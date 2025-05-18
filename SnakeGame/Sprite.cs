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

        // Автоматически обновляем Location при изменении X или Y
        private int _x, _y;
        public int X
        {
            get => _x;
            set { _x = value; this.Location = new Point(_x, _y); }
        }
        public int Y
        {
            get => _y;
            set { _y = value; this.Location = new Point(_x, _y); }
        }


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
            this.X = x;
            this.Y = y;
            this.Location = new Point(x, y);
            
        }
        
        
     
        
    }
}
