using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Game : Form
    {
        Area area = new Area();
        Snake snake = new Snake();
        public Game()
        {
            InitializeComponent();
            InitializeGameArea();
        }

        private void InitializeGameArea()
        {
            this.Height = 600;
            this.Width = 600;

            this.Controls.Add(area);
            //this.MaximumSize = area.Size;
            //this.MinimumSize = area.Size;
            area.Top = 100;
            area.Left = 100;

            snake.Render(this);
        }
    }
}
