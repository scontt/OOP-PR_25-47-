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
    delegate void MyEventHandler(char[] arr);
    public partial class Form1 : Form
    {
        char[] array = new char[11];
        int sum, count,
            k = 0;

        public Form1()
        {
            InitializeComponent();
            resultRichTextBox.ReadOnly = true;
        }

        private void addElemButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (k < 11)
                {
                    array[k] = Convert.ToChar(symbTextBox.Text);
                    arrayListBox.Items.Add(array[k]);
                    k++;
                }
                else { MessageBox.Show("Массив полон!", "Ошибка"); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите символ!", "Ошибка");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void symbTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (symbTextBox.Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            MyEvent first = new MyEvent();
            MyEvent second = new MyEvent();
            MyEvent third = new MyEvent();

            if (sumCheckBox.Checked)
            {
                try
                {
                    first.SomeEvent += (arr) =>
                    {
                        sum = (int)arr[0] + (int)arr[k - 1];
                        resultRichTextBox.AppendText("Сумма кодов первого и последнего элементов массива: " + sum + "\r");
                    };
                    first.checkBoxChecked(array);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Массив пуст!", "Ошибка");
                    return;
                }
            }
            if (countCheckBox.Checked)
            {
                count = 0;

                second.SomeEvent += (arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((int)arr[i] % 2 == 1)
                        {
                            count++;
                        }
                    }
                    resultRichTextBox.AppendText($"Количество символов с нечетным кодом: {count}\r");
                };
                second.checkBoxChecked(array);
            }
            if (lengthCheckBox.Checked)
            {
                third.SomeEvent += (arr) =>
                {
                    resultRichTextBox.AppendText("Длина вашего массива символов: " + k + "\r");
                };
                third.checkBoxChecked(array);
            }
        }
    }

    class MyEvent
    {
        public event MyEventHandler SomeEvent;
        public void checkBoxChecked(char[] mas)
        {
            if (SomeEvent != null) SomeEvent(mas);
        }
    }
}
