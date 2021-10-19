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
    public partial class Form1 : Form
    {
        bool s, d;
        PictureBox player1;
        List<PictureBox> player1tail;
        PictureBox player2;
        Timer timer;
        int speed;
        double direction;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 60;
            timer.Tick += Timer_Tick;
            speed = 2;
            direction = Math.PI/4;
            player1tail = new List<PictureBox>();
            player1 = new PictureBox();
            player1.Width = 10;
            player1.Height = 10;
            player1.Location = new Point(0, 0);
            player1.BackColor = Color.Blue;
            this.Controls.Add(player1);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var x = Math.Sin(direction) * speed;
            var y = Math.Cos(direction) * speed;
            player1tail.Add(player1);
            player1 = new PictureBox();
            player1.Width = 10;
            player1.Height = 10;
            player1.BackColor = Color.Blue;
            player1.Location = new Point(player1tail.Last().Location.X + Convert.ToInt32(Math.Round(x)), player1tail.Last().Location.Y + Convert.ToInt32(Math.Round(y)));
            this.Controls.Add(player1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
            {
                direction += 0.5;
            }
            else if (e.KeyCode == Keys.F)
            {
                direction -= 0.5;
            }
        }
    }
}
