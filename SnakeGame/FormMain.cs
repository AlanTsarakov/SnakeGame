using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FormMain : Form
    {
        Snake snake;
        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            snake = new Snake(this, 10, 10, 100);
            
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Up);
                snake.MoveSnake();
            }
            else if (e.KeyCode == Keys.Down)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Down);
                snake.MoveSnake();
            }
            else if (e.KeyCode == Keys.Right)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Right);
                snake.MoveSnake();
            }
            else if (e.KeyCode == Keys.Left)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Left);
                snake.MoveSnake();
            }
        }
    }
}
