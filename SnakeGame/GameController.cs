using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace SnakeGame
{
    public class GameController
    {
        public Form form;

        Snake snake;
        Food food;
        int points;
        Label labelPoints = new Label();
        

        Timer timer = new Timer();
        public GameController(Form form)
        {
            this.form = form;

            form.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            form.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);

            snake = new Snake(form, 3, 20);
            food = new Food(form);

            playSimpleSound();

            //Button buttonTimer = new Button();
            //buttonTimer.Click += ButtonTimer_Click;
            //buttonTimer.Location = new Point(405, 80);
            //form.KeyPreview = true;
            //buttonTimer.TabStop = false;
            //form.Controls.Add(buttonTimer);

            labelPoints.Text = "Количество очков: ";
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(405, 10);
            labelPoints.ForeColor = Color.White;
            labelPoints.Font = new Font("Impact", 16);
            form.Controls.Add(labelPoints);

            timer.Interval = 250;
            timer.Tick += Timer_Tick;

  
        }

        private void ButtonTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"music.wav");
            simpleSound.Play();
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);

            // Вертикальные линии
            for (int i = 0; i < 21; i++)
            {
                g.DrawLine(pen, new Point(i * 20, 0), new Point(i * 20, 400));
            }

            // Горизонтальные линии
            for (int i = 0; i < 21; i++)
            {
                g.DrawLine(pen, new Point(0, i * 20), new Point(400, i * 20));
            }

            pen.Dispose(); // Важно освободить ресурсы
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            snake.MoveSnake();

            if (snake.CheckTailCollision() == true || snake.Head.X < 0 || snake.Head.Y < 0 || snake.Head.X >= 400 || snake.Head.Y >= 400)
            {
                timer.Stop();
                MessageBox.Show("Вы проиграли!");

                FormAddRecord form = new FormAddRecord(points);
                form.ShowDialog();

                ResetGame();
            }

            if (snake.CheckFoodCollision(food) == true)
            {
                food.MoveFood();
                snake.Grow();
                points++;
                labelPoints.Text = "Количество очков: " + points;
            }
        }

        private void ResetGame()
        {
            timer.Stop();

            snake.Clear();


            form.Controls.Remove(food);

            snake = new Snake(form, 3, 20);
            food = new Food(form);

            points = 0;

            labelPoints.Text = "Количество очков: " + points;
            form.Controls.Add(labelPoints);

        }
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            timer.Start();
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
