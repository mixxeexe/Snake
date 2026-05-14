using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Snake : Form
    {
        bool moveUp, moveDown, moveLeft, moveRight;


        int snakeX = 330;
        int snakeY = 205;

        int speed = 10;

        Random radom = new Random();

        List<Point> snakParts = new
        List<Point>();
        int snakewielk = 25;

        int japuszkoX = 300 ;
        int japuszkoY = 300 ;


        public Snake()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            timer1.Interval = 100;
            timer1.Tick += UpdateGame;
            timer1.Start();

            this.Paint += rysujSnake;
            this.KeyDown += Snake_KeyDown;
            this.KeyUp += Snake_KeyUp;

            snakParts.Add(new Point(snakeX, snakeY));
        }


        private void Snake_Load(object sender, EventArgs e)
        {
            moveRight = true;
        }

        private void UpdateGame(object sender, EventArgs e)
        {

            if (moveUp) snakeY -= speed;
            if (moveDown) snakeY += speed;
            if (moveLeft) snakeX -= speed;
            if (moveRight) snakeX += speed;

            if (snakeX < 0)
                snakeX = this.ClientSize.Width +50;
            if (snakeX > this.ClientSize.Width +50)
                snakeX = 0;

            if (snakeY < 0)
                snakeY = this.ClientSize.Height + 50;
            if (snakeY > this.ClientSize.Height + 50)
                snakeY = 0;

            snakParts.Insert(0, new Point(snakeX, snakeY));

            Rectangle wazRect = new
            Rectangle(snakeX, snakeY, snakewielk, snakewielk);
            Rectangle jabkoRect = new
            Rectangle(japuszkoX, japuszkoY, 25, 25);

            if (wazRect.IntersectsWith(jabkoRect))
            {
                GeneracjaJablek();
            }
            else
            {
                snakParts.RemoveAt(snakParts.Count - 1);
            }

            for (int i = 1; i < snakParts.Count; i++)
            {
                if (snakParts[0] == snakParts[i])
                {
                    timer1.Stop();

                    MessageBox.Show("wąż kaput");

                    return;
                }
            }

            Invalidate();
        }
        private void rysujSnake(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Point part in snakParts)
            {
                g.FillRectangle(Brushes.Lime, part.X, part.Y, snakewielk, snakewielk);

            }

            g.FillEllipse(Brushes.Red, japuszkoX, japuszkoY, 25, 25);
        }

        private void GeneracjaJablek()
        {
            int margin = 100;
            japuszkoX = radom.Next(margin, this.ClientSize.Width - snakewielk -margin );
            japuszkoY = radom.Next(margin, this.ClientSize.Height - snakewielk -margin);
            
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && !moveDown)
            {
                moveUp = true;
                moveDown = false;
                moveLeft = false;
                moveRight = false;

            }

            if (e.KeyCode == Keys.Down && !moveUp)
            {
                moveDown = true;
                moveLeft = false;
                moveRight = false;
                moveUp = false;
            }

            if (e.KeyCode == Keys.Left && !moveRight)
            {
                moveLeft = true;
                moveRight = false;
                moveUp = false;
                moveDown = false;
            }

            if (e.KeyCode == Keys.Right && !moveLeft)
            {
                moveRight = true;
                moveUp = false;
                moveDown = false;
                moveLeft = false;
            }

        }

        private void Snake_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Snake_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}