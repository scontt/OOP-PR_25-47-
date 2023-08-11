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
        string name;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            richTextBox1.BackColor = Color.White;
            richTextBox2.ReadOnly = true;
            richTextBox2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            richTextBox2.Text = $"Реклама: \nЗдравствуйте, {name}, cоздавайте код быстрее и работайте эффективнее. " +
                $"Создайте будущее с Visual Studio 2022.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
