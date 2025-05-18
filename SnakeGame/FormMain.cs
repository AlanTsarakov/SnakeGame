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


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
 
            GameController game = new GameController(this);

            DoubleBuffered = true;


        }
        //private void ResetGame()
        //{
        //    // Остановить текущий таймер
        //    timer.Stop();

        //    // Удалить старые змейки и еду
        //    snake1.Clear();

            
        //    Controls.Remove(food);

        //    // Создать новые объекты
        //    snake1 = new Snake(this, 3, 20);

        //    food = new Food(this);

        //    // Сбросить очки
        //    points = 0;
        //    labelPoints.Text = "Очки: 0";

        //    // Запустить таймер заново
        //    timer.Start();
        //}

        //private void Timer_Tick(object sender, EventArgs e)
        //{

        //    snake1.MoveSnake();

        //    if (snake1.CheckTailCollision() == true)
        //    {
        //        timer.Stop();
        //        MessageBox.Show("Вы проиграли!");
                
        //        ResetGame();
        //    }

        //    if (snake1.CheckFoodCollision(food) == true)
        //    {
        //        food.MoveFood();
        //        snake1.Grow();
        //        points++;
        //        labelPoints.Text = "Количество очков:" + points;
        //    }
        //}

        //private void FormMain_KeyDown(object sender, KeyEventArgs e)
        //{
        //    timer.Start();
        //    if (e.KeyCode == Keys.Up && snake1.GetSnakeDirection() != Snake.SnakeDirection.Down)
        //    {
        //        snake1.SetSnakeDirection(Snake.SnakeDirection.Up);
        //        snake1.MoveSnake();


        //    }
        //    else if (e.KeyCode == Keys.Down && snake1.GetSnakeDirection() != Snake.SnakeDirection.Up)
        //    {
        //        snake1.SetSnakeDirection(Snake.SnakeDirection.Down);
        //        snake1.MoveSnake();


        //    }
        //    else if (e.KeyCode == Keys.Right && snake1.GetSnakeDirection() != Snake.SnakeDirection.Left)
        //    {
        //        snake1.SetSnakeDirection(Snake.SnakeDirection.Right);
        //        snake1.MoveSnake();

        //    }
        //    else if (e.KeyCode == Keys.Left && snake1.GetSnakeDirection() != Snake.SnakeDirection.Right)
        //    {
        //        snake1.SetSnakeDirection(Snake.SnakeDirection.Left);
        //        snake1.MoveSnake();
        //    }



           
        //}

        

    
    }

    
}
