using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Snake
    {
        public List<PictureBox> snakePixels = new List<PictureBox>();
        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake()
        {
            AddPixel(300, 300);
            AddPixel(280, 300);
            AddPixel(300, 320);
        }

        private void AddPixel(int left, int top)
        {
            PictureBox snakePixel;
            snakePixel = new PictureBox();
            snakePixel.Height = 20;
            snakePixel.Width = 20;
            snakePixel.BackColor = Color.Orange;
            snakePixel.Left = left;
            snakePixel.Top = top;
            snakePixels.Add(snakePixel);
        }

        public void Render(Form form)
        {
            foreach (var sp in snakePixels)
            {
                form.Controls.Add(sp);
                sp.BringToFront();
            }
        }
    }
}
