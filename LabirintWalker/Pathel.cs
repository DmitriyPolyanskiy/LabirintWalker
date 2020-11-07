using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirintWalker
{
    class Pathel//Path + element - элемент пути
    {
        private Form1.PType type;
        public Form1.PType Type
        {
            get { return type; }
            set { type = value; }
        }
        private Point position;

        private Point previous;

        public int X
        {
            get { return position.X; }
            set { position.X = value; }
        }
        public int X_
        {
            get { return previous.X; }
            set { previous.X = value; }
        }

        public int Y
        {
            get { return position.Y; }
            set { position.Y = value; }
        }
        public int Y_
        {
            get { return previous.Y; }
            set { previous.Y = value; }
        }

        public Pathel(int x, int y, int x_, int y_, Form1.PType p)
        {
            Type = p;
            X_ = x_;
            Y_ = y_;
            X = x;
            Y = y;
        }

    }
}
