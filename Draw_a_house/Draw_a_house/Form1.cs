using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Draw_a_house
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 500;
            this.Width = 500;
           
        }

        private void house(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen mypen = new Pen(Color.Brown);
            Brush mybrush = new SolidBrush(Color.Red);

            //g.DrawLine(mypen, 50, 100, 250, 10);
            //g.DrawLine(mypen, 250, 10,450,100);
            //g.DrawLine(mypen, 70, 90, 430, 90);
            //g.DrawRectangle(mypen, 70, 90, 360, 200);

            Rectangle rect = new Rectangle(70, 90, 360, 200);
            e.Graphics.FillRectangle(mybrush, rect);

            Point pt = new Point(50,100);
            Point pnt = new Point(250,10);
            Point p3 = new Point(430,90);

            Point[] arr = {pt,pnt,p3};



            g.DrawPolygon(mypen, arr);
            e.Graphics.FillPolygon(new SolidBrush(Color.Yellow), arr);




        }
    }
}
