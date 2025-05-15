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
        Sprite sprite;
        Snake snake;

        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            sprite = new Sprite(this, 10, 80, 20);
            snake = new Snake(this, snake, 10);
            Sprite sprite1 = new Sprite(this, 100, 100, 100);
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
           



        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            snake.MoveSnake();
            
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && snake.GetSnakeDirection() != Snake.SnakeDirection.Down)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Up);
                snake.MoveSnake();


            }
            else if (e.KeyCode == Keys.Down && snake.GetSnakeDirection() != Snake.SnakeDirection.Up)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Down);
                snake.MoveSnake();


            }
            else if (e.KeyCode == Keys.Right && snake.GetSnakeDirection() != Snake.SnakeDirection.Left)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Right);
                snake.MoveSnake();

            }
            else if (e.KeyCode == Keys.Left && snake.GetSnakeDirection() != Snake.SnakeDirection.Right)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Left);
                snake.MoveSnake();
            }
        }

        
    }
}
