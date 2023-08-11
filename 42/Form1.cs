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
        int arrLength, start, end;
        double[] array;
        private void button3_Click(object sender, EventArgs e)
        {
            if (plusRadioButton.Checked)
            {
                richTextBox1.Clear();
                arrLength = Convert.ToInt32(arrayLengthTextBox.Text);
                start = Convert.ToInt32(startBoundTextBox.Text);
                end = Convert.ToInt32(endBoundTextBox.Text);

                array = new double[arrLength];
                SecondClass plus = new SecondClass(arrLength);
                Random rand = new Random();
                richTextBox1.AppendText("Исходный массив: \r\n");
                for (int i = 0; i < arrLength; i++)
                {
                    array[i] = rand.Next(start, end) + Math.Round(rand.NextDouble(), 1);
                    plus[i] = array[i];

                    richTextBox1.AppendText(array[i] + " || ");
                }
                richTextBox1.AppendText("\r\nИзмененный массив: \r\n");
                for (int i = 0; i < arrLength; i++)
                {
                    if (true)
                    {
                        richTextBox1.AppendText(plus[i].ToString() + " || ");
                    }
                }
                richTextBox1.Text += "\r\n";
            }
            else if (minusRadioButton.Checked)
            {
                richTextBox1.Clear();
                arrLength = Convert.ToInt32(arrayLengthTextBox.Text);
                start = Convert.ToInt32(startBoundTextBox.Text);
                end = Convert.ToInt32(endBoundTextBox.Text);

                array = new double[arrLength];
                FirstClass minus = new FirstClass(arrLength, start, end);
                Random rand = new Random();
                richTextBox1.AppendText("Исходный массив: \r\n");
                for (int i = 0; i < arrLength; i++)
                {
                    //array[i] = Math.Round(rand.NextDouble() * end - Math.Abs(start), 2
                    array[i] = rand.Next(start, end) + Math.Round(rand.NextDouble(), 2);
                    minus[i] = array[i];

                    // Вывод исходного массива
                    richTextBox1.AppendText(array[i].ToString() + " || ");
                }
                richTextBox1.AppendText("\r\nИзмененный массив: \r\n");
                for (int i = 0; i < arrLength; i++)
                {
                    richTextBox1.AppendText(minus[i].ToString() + " || ");
                }
                richTextBox1.Text += "\r\n";
            }
            else MessageBox.Show("Выберите действие", "Ошибка");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }
    }

    public interface IDigits
    {
        int Method();
        double this[int index] { get; set; }
    }

    public class FirstClass : IDigits
    {
        double[] arr;
        int N;

        public FirstClass(int N, int start, int end)
        {
            this.N = N;
            arr = new double[N];
        }
        public int Method()
        {
            double avg = 0;
            for (int i = 0; i < N; i++)
            {
                avg += arr[i];
            }
            return (int)avg;
        }
        public double this[int index]
        { 
            get { return arr[index]; }
            set 
            {
                if (value < 0) arr[index] = Math.Round(value, 2);
                else if (value > 0) arr[index] = Math.Round(value, 2) * -1;
            }
        }
    }

    public class SecondClass : IDigits
    {
        double[] arr;
        public SecondClass(int N)
        {
            arr = new double[N];
        }
        public int Method()
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            Math.Round(avg /= arr.Length, 2);
            avg %= 1;
            avg *= 100;
            return (int)avg;
        }
        public double this[int index]
        {
            get { return arr[index]; }
            set
            {
                if (value > 0) arr[index] = Math.Round(value, 1);
                else if (value < 0) arr[index] = Math.Round(Math.Abs(value), 1);
            }
        }
    }
}
