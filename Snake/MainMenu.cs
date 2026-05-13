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
        public Snake()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            timer1.Interval = 100;
            timer1.Tick += UpdateGame;
            timer1.Start();

            this.Paint += rysujSnake;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) moveUp = false;
            if (e.KeyCode == Keys.Down) moveDown = false;
            if (e.KeyCode == Keys.Left) moveLeft = false;
            if (e.KeyCode == Keys.Right) moveRight = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) moveUp = true;
            if (e.KeyCode == Keys.Down) moveDown = true;
            if (e.KeyCode == Keys.Left) moveLeft = true;
            if (e.KeyCode == Keys.Right) moveRight = true;
        }

        private void Snake_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGame(object sender, EventArgs e)
        {
            if (moveUp) snakeY -= speed;
            if (moveDown) snakeY += speed;
            if (moveLeft) snakeX -= speed;
            if (moveRight) snakeX += speed;

            if (snakeX < 0)
                snakeX = this.ClientSize.Width;
            if (snakeX > this.ClientSize.Width)
                snakeX = 0;

            if (snakeY < 0)
                snakeY = this.ClientSize.Height;
            if (snakeY > this.ClientSize.Height)
                snakeY = 0;


            Invalidate();
        }
        private void rysujSnake(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Lime, snakeX,snakeY , 25, 25);
        }
    }
}
