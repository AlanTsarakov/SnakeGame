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
        GameController game;

        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            snake = new Snake(this, 10, 80, 20);
            game = new GameController(this, snake);
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
           



        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            game.MoveSnake();
            
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Up);


            }
            else if (e.KeyCode == Keys.Down)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Down);
 
           

            }
            else if (e.KeyCode == Keys.Right)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Right);
          

            }
            else if (e.KeyCode == Keys.Left)
            {
                snake.SetSnakeDirection(Snake.SnakeDirection.Left);
      
            }
        }

        
    }
}
