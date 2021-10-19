using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Snake
{
    class Snake
    {
        public double Speed     { get; set; }
        public double Direction { get; set; }
        public Point Head       { get; set; }
        public List<Point> Tail { get; set; }
        public double TurnSpeed { get; set; } = 0.2;

        public Snake()
        {
                  Head = new Point();
            Tail = new List<Point>();
        }

        public Snake(Point head)
        {
                         Head = head;
            Tail = new List<Point>();
        }

        public void  TurnLeft()
        {
            Direction += TurnSpeed;
        }

        public void TurnRight()
        {
            Direction -= TurnSpeed;
        }
    }
}
