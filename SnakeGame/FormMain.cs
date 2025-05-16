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
        Snake snake1;
        Snake snake2;
        Food food;
        int points;
        Timer timer;
        Label labelPoints = new Label();

        public FormMain()
        {
            InitializeComponent();

            
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            snake1 = new Snake(this, 3, 20);
            snake2 = new Snake(this, 3, 20);
            food = new Food(this);
            timer = new Timer();
            timer.Interval = 250;
            timer.Tick += Timer_Tick;
            

            DoubleBuffered = true;
            labelPoints.Text = "Количество очков:";
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(200, 10);
            Controls.Add(labelPoints);

           



        }
        private void ResetGame()
        {
            // Остановить текущий таймер
            timer.Stop();

            // Удалить старые змейки и еду
            snake1.Clear();
            snake2.Clear();
            
            Controls.Remove(food);

            // Создать новые объекты
            snake1 = new Snake(this, 3, 20);
            snake2 = new Snake(this, 3, 20);
            food = new Food(this);

            // Сбросить очки
            points = 0;
            labelPoints.Text = "Очки: 0";

            // Запустить таймер заново
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            snake1.MoveSnake();
            snake2.MoveSnake();
            if (snake1.CheckTailCollision() == true)
            {
                timer.Stop();
                MessageBox.Show("Вы проиграли!");
                
                ResetGame();
            }

            if (snake1.CheckFoodCollision(food) == true)
            {
                food.MoveFood();
                snake1.Grow();
                points++;
                labelPoints.Text = "Количество очков:" + points;
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            timer.Start();
            if (e.KeyCode == Keys.Up && snake1.GetSnakeDirection() != Snake.SnakeDirection.Down)
            {
                snake1.SetSnakeDirection(Snake.SnakeDirection.Up);
                snake1.MoveSnake();


            }
            else if (e.KeyCode == Keys.Down && snake1.GetSnakeDirection() != Snake.SnakeDirection.Up)
            {
                snake1.SetSnakeDirection(Snake.SnakeDirection.Down);
                snake1.MoveSnake();


            }
            else if (e.KeyCode == Keys.Right && snake1.GetSnakeDirection() != Snake.SnakeDirection.Left)
            {
                snake1.SetSnakeDirection(Snake.SnakeDirection.Right);
                snake1.MoveSnake();

            }
            else if (e.KeyCode == Keys.Left && snake1.GetSnakeDirection() != Snake.SnakeDirection.Right)
            {
                snake1.SetSnakeDirection(Snake.SnakeDirection.Left);
                snake1.MoveSnake();
            }



            if (e.KeyCode == Keys.W && snake2.GetSnakeDirection() != Snake.SnakeDirection.Down)
            {
                snake2.SetSnakeDirection(Snake.SnakeDirection.Up);
                snake2.MoveSnake();


            }
            else if (e.KeyCode == Keys.S && snake2.GetSnakeDirection() != Snake.SnakeDirection.Up)
            {
                snake2.SetSnakeDirection(Snake.SnakeDirection.Down);
                snake2.MoveSnake();


            }
            else if (e.KeyCode == Keys.D && snake2.GetSnakeDirection() != Snake.SnakeDirection.Left)
            {
                snake2.SetSnakeDirection(Snake.SnakeDirection.Right);
                snake2.MoveSnake();

            }
            else if (e.KeyCode == Keys.A && snake2.GetSnakeDirection() != Snake.SnakeDirection.Right)
            {
                snake2.SetSnakeDirection(Snake.SnakeDirection.Left);
                snake2.MoveSnake();
            }
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);

            // Вертикальные линии
            for (int i = 0; i < 70; i++)
            {
                g.DrawLine(pen, new Point(i * 10, 0), new Point(i * 10, 400));
            }

            // Горизонтальные линии
            for (int i = 0; i < 40; i++)
            {
                g.DrawLine(pen, new Point(0, i * 10), new Point(700, i * 10));
            }

            pen.Dispose(); // Важно освободить ресурсы
        }

    
    }

    
}
