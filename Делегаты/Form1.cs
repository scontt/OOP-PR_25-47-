using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Делегаты
{
    public partial class Form1 : Form
    {
        delegate int StrMod(string str, string s);
        StrMod deletumother;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deletumother = new StrMod(SymbCount);
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                richTextBox1.Text = $"Количество символов {textBox2.Text} в введенной вами строке: " +
            deletumother(textBox1.Text, textBox2.Text).ToString();
            }
            else MessageBox.Show("Заполните оба поля", "Ошибка!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletumother = new StrMod(SymbCodeCount);
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                richTextBox1.Text = $"Количество символов в введенной вами строке, коды которых больше кода символа {textBox2.Text}: " +
                deletumother(textBox1.Text, textBox2.Text);
            }
            else MessageBox.Show("Заполните оба поля", "Ошибка!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        static int SymbCount(string s, string t)
        {
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Convert.ToChar(t) == s[i]) counter++;
            }
            return counter;
        }

        static int SymbCodeCount(string str, string sym)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)Convert.ToChar(sym) < (int)str[i]) counter++;
            }
            return counter;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (textBox2.Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
