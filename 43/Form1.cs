using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int N = 4;
        Chocolate<int> dove;
        Chocolate<double> milka;
        int[,] intArray = new int[N, N];
        double[,] doubleArray = new double[N, N];

        public Form1()
        {
            InitializeComponent();
            sourceDataGridView.RowCount = N;
            sourceDataGridView.ColumnCount = N;
            sourceDataGridView.RowHeadersVisible = false;
            sourceDataGridView.ColumnHeadersVisible = false;
            for (int i = 0; i < N; i++)
            {
                sourceDataGridView.Rows[i].Height = 40;
                sourceDataGridView.Columns[i].Width = 40;
            }
            sourceDataGridView.Height = 163;
            sourceDataGridView.Width = 163;
            sourceDataGridView.ReadOnly = true;

            resultDataGridView.RowCount = N;
            resultDataGridView.ColumnCount = N;
            resultDataGridView.RowHeadersVisible = false;
            resultDataGridView.ColumnHeadersVisible = false;
            for (int i = 0; i < N; i++)
            {
                resultDataGridView.Rows[i].Height = 40;
                resultDataGridView.Columns[i].Width = 40;
            }
            resultDataGridView.Height = 163;
            resultDataGridView.Width = 163;
            resultDataGridView.ReadOnly = true;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int start = Convert.ToInt32(startTextBox.Text);
            int end = Convert.ToInt32(endTextBox.Text);

            if (intRadioButton.Checked)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        intArray[i, j] = rand.Next(start, end);
                    }
                }
                dove = new Chocolate<int>(intArray);
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        sourceDataGridView.Rows[i].Cells[j].Value = intArray[i, j];
                    }
                }
            }
            else if (doubleRadioButton.Checked)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        doubleArray[i, j] = rand.Next(start, end) + Math.Round(rand.NextDouble(), 2);
                    }
                }
                milka = new Chocolate<double>(doubleArray);
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        sourceDataGridView.Rows[i].Cells[j].Value = doubleArray[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите тип массива!", "Ошибка");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            if (intRadioButton.Checked)
            {
                dove.Change();
                intArray = dove.GetArray();
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        resultDataGridView.Rows[i].Cells[j].Value = intArray[i, j];
                    }
                }
            }
            else if (doubleRadioButton.Checked)
            {
                milka.Change();
                doubleArray = milka.GetArray();
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        resultDataGridView.Rows[i].Cells[j].Value = Math.Round(doubleArray[i, j], 2);
                    }
                }
            }
        }

        private void digitsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }

    public class Chocolate<A> where A : IComparable<A>
    {
        const int N = 4;
        A[,] arr = new A[N, N];
        A[] arr2 = new A[5];

        public Chocolate(A[,] array)
        {
            arr = array;
        }

        public void Change()
        { 
            for (int i = 0; i < N; i++)
            {
                A min = arr[i, 0],
                max = arr[i, 0];
                for (int j = 0; j < N; j++)
                {
                    if (arr[i, j].CompareTo(min) < 0)
                    {
                        min = arr[i, j];
                    }
                    if (arr[i, j].CompareTo(max) > 0)
                    {
                        max = arr[i, j];
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    arr[i, i] = Avg(min, max);
                }
            }
        }

        public A[,] GetArray()
        {
            return arr;
        }

        private A Avg(A x, A y)
        {
            dynamic a = x;
            dynamic b = y;
            return (a + b) / 2;
        }
    }
}
