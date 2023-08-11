using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int n;
        double x;
        public Form1()
        {
            InitializeComponent();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(nTextBox.Text);
            x = Convert.ToDouble(xTextBox.Text);
            resultLabel.Text = Func(x, 1, n).ToString();
        }

        private void nTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) return;
            if (Char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void xTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) return;
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == ',' && xTextBox.Text.Length > 0 && xTextBox.Text.IndexOf(',') == -1) return;
            if (e.KeyChar == '-' && xTextBox.Text.Length == 0 && xTextBox.Text.IndexOf('-') == -1) return;
            e.Handled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public double Func(double y, int k, int c)
        {
            if (k == c + 1) return y;
            return y / (k + Func(y, k + 1, c));
        }
    }
}