using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _x1, _y1;
        private Pen myPen;
        private Graphics g;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left )
            {
                g.DrawLine(myPen,_x1,_y1,e.X,e.Y);
            }
            _x1 = e.X;
            _y1 = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            myPen = new Pen(Color.Blue, 5);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                _x1 = e.X;
                _y1 = e.Y;
            }
            else if(e.Button == MouseButtons.Right)
            {
                this.Refresh();
            }

        }
    }
}
