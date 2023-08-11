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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Программа позволяет определить среднее арифметическое каждого столбца двумерного массива целых или вещественных чисел" +
                "с помощью перегруженного метода";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
