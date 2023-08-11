using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Massiv arr;
        string formArray;
        int num, sum;
        const string ERROR = "Ошибка";
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }

        private void fillArrayButton_Click(object sender, EventArgs e)
        {
            if (startBoundTextBox.Text.Length == 0 || endBoundTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите границы диапазона!", ERROR);
                return;
            }
            try
            {
                int start = Convert.ToInt32(startBoundTextBox.Text);
                int end = Convert.ToInt32(endBoundTextBox.Text);
                arr = new Massiv(start, end);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целые числа!", ERROR);
                return;
            }
            arr.ArrayOut(ref formArray);
            richTextBox1.Text = "Исходный массив: " + "\r" + formArray;
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            try
            {
                arr.Sum(ref sum);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Массив пуст!", "Ошибка");
                return;
            }
            richTextBox1.AppendText("Сумма отрицательных элементов массива: " + sum.ToString() + "\r");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void numChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                num = Convert.ToInt32(numChangeTextBox.Text);
                arr.NumChange(num);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число для замены!", ERROR);
                return;
            }
            arr.ArrayOut(ref formArray);
            richTextBox1.AppendText("Изменный массив: " + "\r" + formArray + "\r");
        }
    }

    public class Massiv
    {
        string array;
        int[,] digits = new int[7, 7];
        Random rand = new Random();

        public Massiv(int startBound, int endBound)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    digits[i, j] = rand.Next(startBound, endBound + 1);
                }
            }
        }

        public void ArrayOut(ref string text)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array += digits[i, j].ToString() + "\t";
                }
                array += "\r";
            }
            text = array + "\r";
            array = "";
        }

        public void NumChange(int num)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (((j + 1) % 2 == 0) && digits[i, j] > 0) digits[i, j] = num;
                }
            }
        }

        public int Sum(ref int sum)
        {
            sum = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (digits[i, j] < 0) sum += digits[i, j];
                }
            }
            return sum;
        }
    }
}