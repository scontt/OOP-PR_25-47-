using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a, b, c;
        Shape circle = new Shape();

        private void inputButton_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(aTextBox.Text);
            b = Convert.ToDouble(bTextBox.Text);
            c = Convert.ToDouble(cTextBox.Text);
            circle.Figure(a, b, c);
            radiusTextBox.Text = Convert.ToString(circle.Radius);
        }

        private void atextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) return;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',') return;
            e.Handled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = default;
            radiusTextBox.Text = default;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(aTextBox.Text);
            b = Convert.ToDouble(bTextBox.Text);
            c = Convert.ToDouble(cTextBox.Text);
            circle = new Drawing(pictureBox1, pictureBox1.Width / 2, pictureBox1.Height / 2);
            circle.Figure(a, b, c);
            radiusTextBox.Text = Convert.ToString(circle.Radius);
        }

        public Form1()
        {
            InitializeComponent();
            radiusTextBox.ReadOnly = true;
        }
    }

    public class Shape
    {
        double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public virtual void Figure(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            radius = Math.Sqrt((p - a) * (p - b) * (p - c) / p);
        }
    }

    public class Drawing : Shape
    {
        PictureBox pictureBox;
        float x, y;
        float cr_diag;
        public Drawing(PictureBox pB, float xs, float ys)
        {
            pictureBox = pB;
            y = ys;
            x = xs;
        }
        public override void Figure(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            Radius = Math.Sqrt((p - a) * (p - b) * (p - c) / p);
            cr_diag = (float)Radius * 2;
            //sq_diag = Math.Sqrt(2) * cr_diag;
            x -= (float)Radius;
            y -= (float)Radius;
            //e.Graphics.FillEllipse(Brushes.Red, x, y, cr_diag, cr_diag);
            Bitmap btmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics e = Graphics.FromImage(btmp);
            e.FillEllipse(Brushes.Red, x, y, cr_diag, cr_diag);
            pictureBox.Image = btmp;

            //drawing.DrawEllipse(redPen, 0, 0, (float)Radius * 2, (float)Radius * 2);
        }
    }
}
