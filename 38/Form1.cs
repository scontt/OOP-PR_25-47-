using System;
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
        public Form1()
        {
            InitializeComponent();
            exitButton.BackColor = Color.FromArgb(231, 142, 142);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form intro = new Intro();
            this.Hide();
            intro.ShowDialog();
            intro.Close();
            Form signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
        }

        private void calculButton_Click(object sender, EventArgs e)
        {
            Edifier r1100 = new Edifier(userTextBox.Text);
            r1100.Average();
            resultLabel.Text = "Среднее арифметическое кодов символов строки, имеющих четный индекс: " + r1100.Avg;
            Marshall major = new Marshall(userTextBox.Text);
            major.Count();
            oddLabel.Text = "Количество символов, имеющих нечетный код: " + major.Odd;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void userTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) calculButton_Click(sender, e);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form info = new Info();
            info.Show();
        }
    }

    public class Edifier
    {
        protected string str;
        double avg;

        public Edifier(string text)
        {
            str = text;
            avg = 0.0;
        }

        public void Average()
        {
            double sum = 0.0;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += (int)str[i];
                    count++;
                }
            }
            avg = Math.Round(sum / count, 3);
        }

        public double Avg
        {
            get { return avg; }
            set { avg = value; }
        }
    }

    public class Marshall : Edifier
    {
        int odd;

        public Marshall(string text) : base(text)
        {
            odd = 0;
        }

        public void Count()
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] % 2 == 1) count++;
            }
            odd = count;
        }

        public int Odd
        {
            get { return odd; }
            set { odd = value; }
        }
    }
}
