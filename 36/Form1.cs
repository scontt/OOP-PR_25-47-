using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DateTime current = new DateTime();
        DateTime start = DateTime.Now;
        LirbraryClass check = new LirbraryClass(); // Объект библиотечного класса
        const int N = 9;
        int k = 0,
            gridIter = 0;
        double[] array = new double[N];

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            current = DateTime.Now;
            label1.Text = check.Time(current, start);
        }

        private void addElemButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Генерация исключения, если последний введенный символ - запятая
                if (addElemTextBox.Text.IndexOf(',') == addElemTextBox.Text.Length - 1) throw new FormatException();
                array[k] = Convert.ToDouble(addElemTextBox.Text);
                k++;
                addArrayLabel.Text = $"Введите элемент массива.\r\nОсталось: {N - k}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите вещественное число", "Ошибка!");
                return;
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Массив полон", "Ошибка!");
                return;
            }
            //Вывод элементов массива в dataGridView1
            richTextBox1.Text += array[gridIter] + " ";
            gridIter++;
        }


        private void addElemTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space) return;
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '-' && addElemTextBox.Text.Length == 0) return;
            if (e.KeyChar == ',' && addElemTextBox.Text.Length != 0 && addElemTextBox.Text.IndexOf(',') == -1) return;
            e.Handled = true;
        }

        private void addElemTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.addElemButton_Click(sender, e);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = default;
            // Создание объекта библиотечного класса
            LirbraryClass classObject = new LirbraryClass();
            // Сортировка массива методом библиотечного класса
            classObject.Sort(ref array);
            for (int i = 0; i < N; i++)
            {
                richTextBox1.Text += array[i] + " ";
            }
        }
    }
}