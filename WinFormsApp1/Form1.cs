using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap[] image = new Bitmap[3];
        int x = 0;

        Pen myPen;
        Graphics g;
        int color, randcolor;
        PointF point1, point2;
        Random rand = new Random();
        public Form1()
        {
            AutoSize = true;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            Pen myPen = new Pen(Color.Purple, 3);
            //pentagon
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            Point point1 = new Point(100, 200);
            Point point2 = new Point(150, 160);
            Point point3 = new Point(200, 200);
            Point point4 = new Point(180, 270);
            Point point5 = new Point(120, 270);
            Point[] curvePoints =
            {
                 point1, point2, point3, point4, point5
            };
            g.DrawPolygon(myPen, curvePoints);
            //ellipse sector
            SolidBrush brush = new SolidBrush(Color.Purple);
            Rectangle rect = new Rectangle(100, 400, 200, 100);
            float startAngle = 0.0F;
            float sweepAngle = 60.0F;
            //g.DrawEllipse(myPen, rect);
            g.FillPie(brush, rect, startAngle, sweepAngle);
            //rhombus  
            Point p1 = new Point(515, 440);
            Point p2 = new Point(559, 505);
            Point p3 = new Point(515, 570);
            Point p4 = new Point(471, 505);
            Point[] cp =
            {
                 p1, p2, p3, p4,
            };
            g.DrawPolygon(myPen, cp);
            //cube
            Point pnt1 = new Point(500, 140);
            Point pnt2 = new Point(550, 170);
            Point pnt3 = new Point(550, 230);
            Point pnt4 = new Point(500, 260);
            Point pnt5 = new Point(450, 230);
            Point pnt6 = new Point(450, 170);
            //Point pnt7 = new Point(500, 200);
            Point[] curvepnt =
            {
                 pnt1, pnt2, pnt3, pnt4, pnt5, pnt6
            };
            g.DrawPolygon(myPen, curvepnt);
            Point[] points =
             {
                 new Point(550, 170),
                 new Point(500, 200),
                 new Point(450, 170),

             };
            g.DrawLines(myPen, points);
            Point[] point =
             {
                 new Point(500, 200),
                 new Point(500, 260),

             };
            g.DrawLines(myPen, point);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            Pen myPen = new Pen(Color.Blue, 3);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            Point point1 = new Point(300, 200);
            Point point2 = new Point(390, 200);
            Point point3 = new Point(390, 210);
            Point point4 = new Point(410, 430);
            Point point5 = new Point(410, 440);
            Point point6 = new Point(360, 440);
            Point point7 = new Point(360, 430);
            Point point8 = new Point(345, 240);
            Point point9 = new Point(330, 430);
            Point point10 = new Point(330, 440);
            Point point11 = new Point(280, 440);
            Point point12 = new Point(280, 430);
            Point point13 = new Point(300, 210);
            Point[] curvePoints =
            {
                 point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12, point13
            };
            g.DrawPolygon(myPen, curvePoints);
            Point[] point =
            {
                 new Point(300, 210),
                 new Point(390, 210),
            };
            g.DrawLines(myPen, point);
            Point[] pont =
            {
                 new Point(345, 210),
                 new Point(345, 240),
            };
            g.DrawLines(myPen, pont);
            Point[] p =
            {
                 new Point(390, 210),
                 new Point(420, 300)
            };
            Pen mypen = new Pen(Color.Black, 3);
            g.DrawLines(mypen, p);
            Point pnt1 = new Point(420, 300);
            Point pnt2 = new Point(480, 300);
            Point pnt3 = new Point(480, 340);
            Point pnt4 = new Point(420, 340);
            Point[] curvepnt =
            {
                 pnt1, pnt2, pnt3, pnt4
            };
            g.DrawPolygon(mypen, curvepnt);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            g.FillPolygon(brush, curvepnt);
            Point[] l =
            {
                 new Point(430, 310),
                 new Point(440, 310),
                 new Point(440, 320),
                 new Point(430, 320),
                 new Point(430, 330),
                 new Point(442, 330)
            };
            g.DrawLines(mypen, l);
            Point[] line =
            {
                 new Point(445, 315),
                 new Point(455, 315)
            };
            g.DrawLines(mypen, line);
            Point[] lin =
            {
                 new Point(445, 325),
                 new Point(455, 325)
            };
            g.DrawLines(mypen, lin);
            Point[] po =
            {
                 new Point(460, 310),
                 new Point(470, 310),
                 new Point(470, 320),
                 new Point(460, 320),
                 new Point(470, 320),
                 new Point(470, 330),
                 new Point(460, 330)
            };
            g.DrawLines(mypen, po);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            g = Graphics.FromHwnd(pictureBox1.Handle);
            myPen = new Pen(Color.Black, 3);

            g.Clear(Color.White);
            int add = rand.Next(-100, 100);

            switch (rand.Next(1, 3))
            {
                case 1:
                    point1 = new PointF(300.0F + add, 400.0F);
                    point2 = new PointF(500.0F, 400.0F);
                    timer2.Enabled = true;
                    break;
                case 2:
                    point1 = new PointF(300.0F, 400.0F);
                    point2 = new PointF(500.0F + add, 400.0F);
                    timer3.Enabled = true;
                    break;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);

            point1.X = (float)((point1.X - point2.X) * Math.Cos(Math.PI / 180) - (point1.Y - point2.Y) * Math.Sin(Math.PI / 180) + point2.X);
            point1.Y = (float)((point1.X - point2.X) * Math.Sin(Math.PI / 180) + (point1.Y - point2.Y) * Math.Cos(Math.PI / 180) + point2.Y);
            g.DrawLine(myPen, point1, point2);

            color = rand.Next(1, 5);
            randcolor = rand.Next(1, 5);
            if (color == randcolor)
            {
                switch (color)
                {
                    case 1:
                        myPen = new Pen(Color.Blue, 3);
                        break;
                    case 2:
                        myPen = new Pen(Color.Green, 3);
                        break;
                    case 3:
                        myPen = new Pen(Color.Red, 3);
                        break;
                    case 4:
                        myPen = new Pen(Color.Purple, 3);
                        break;
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);

            point2.X = (float)((point2.X - point1.X) * Math.Cos(Math.PI / 180) - (point2.Y - point1.Y) * Math.Sin(Math.PI / 180) + point1.X);
            point2.Y = (float)((point2.X - point1.X) * Math.Sin(Math.PI / 180) + (point2.Y - point1.Y) * Math.Cos(Math.PI / 180) + point1.Y);

            g.DrawLine(myPen, point1, point2);

            color = rand.Next(1, 5);
            randcolor = rand.Next(1, 5);
            if (color == randcolor)
            {
                switch (color)
                {
                    case 1:
                        myPen = new Pen(Color.Blue, 3);
                        break;
                    case 2:
                        myPen = new Pen(Color.Green, 3);
                        break;
                    case 3:
                        myPen = new Pen(Color.Red, 3);
                        break;
                    case 4:
                        myPen = new Pen(Color.Purple, 3);
                        break;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            g.DrawImage(image[0], 10 + x, 10, Convert.ToInt32(image[0].Width / 1.5), Convert.ToInt32(image[0].Height / 1.5));
            g.DrawImage(image[1], -55 + x, 20, Convert.ToInt32(image[1].Width / 1.3), Convert.ToInt32(image[1].Height / 1.3));
            g.DrawImage(image[2], 213 + x, 20, Convert.ToInt32(image[2].Width / 1.3), Convert.ToInt32(image[2].Height / 1.3));
            x += 10;
            image[1].RotateFlip(RotateFlipType.Rotate270FlipNone);
            image[2].RotateFlip(RotateFlipType.Rotate270FlipNone);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            x = 0;
            timer2.Enabled = false;
            timer3.Enabled = false;

            image[0] = new Bitmap(@"C:\Users\Maxim\Desktop\WinFormsApp1\Resources\car.jpg");
            image[1] = new Bitmap(@"C:\Users\Maxim\Desktop\WinFormsApp1\Resources\wheel.png");
            image[2] = new Bitmap(@"C:\Users\Maxim\Desktop\WinFormsApp1\Resources\wheel.png");

            timer1.Enabled = true;
        }
    }
}
