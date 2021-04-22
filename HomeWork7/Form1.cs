using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void buttonDraw_Click(object sender, EventArgs e) 
        {
            if (graphics == null) graphics = panel2.CreateGraphics();
            drawCayleyTree(int.Parse(listBoxDepth.Text), 200, 310,
                           double.Parse(listBox2Length.Text),  
                           -Math.PI / 2, (string)listBoxColor.Text);
            
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th, string color)
        {
            double th1 = double.Parse(listBoxTh1.Text);
            double th2 = double.Parse(listBoxTh2.Text);
            double per1 = double.Parse(listBoxPer1.Text);
            double per2 = double.Parse(listBoxPer2.Text);

            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1, color);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,color);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th - th2, color);
        }

        void drawLine(double x0,double y0,double x1, double y1,string color)
        {
            switch (color)
            {
                case "Red":
                    graphics.DrawLine(
                        Pens.Red,
                        (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Blue":
                    graphics.DrawLine(
                        Pens.Blue,
                        (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Green":
                    graphics.DrawLine(
                        Pens.Green,
                        (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Yellow":
                    graphics.DrawLine(
                        Pens.Yellow,
                        (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                default:break;
            }

        }
    }
}
