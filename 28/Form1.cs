using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int N = 6;
        int check = 0,
            hBubb, hLin, hh, mBubb, mLin, mm, sBubb, sLin, ss, msBubb, msLin, mss;
        string linFaster = "линейным методом",
            bubbFaster = "методом пузырька",
            fast;

        double temp;
        double[,] nums = new double[N, N];

        TimeSpan lin = new TimeSpan();
        TimeSpan bubb = new TimeSpan();
        DateTime bubbTimeStart = new DateTime();

        DateTime bubbTimeEnd = new DateTime();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = N;
            dataGridView1.RowCount = N;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows[i].Height = 50;
                dataGridView1.Columns[i].Width = 50;
            }
            dataGridView1.Height = 303;
            dataGridView1.Width = 303;

            dataGridView2.ReadOnly = true;
            dataGridView2.ColumnCount = N;
            dataGridView2.RowCount = N;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnHeadersVisible = false;
            for (int i = 0; i < N; i++)
            {
                dataGridView2.Rows[i].Height = 50;
                dataGridView2.Columns[i].Width = 50;
            }
            dataGridView2.Height = 303;
            dataGridView2.Width = 303;

            richTextBox1.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Control_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '-')
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void programInfoButton_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime pickerDate = dateTimePicker1.Value;
            DateTime userDate = DateTime.Now;
            if (pickerDate.Date == userDate.Date) richTextBox1.AppendText("Выбранная дата совпадает с текущей\r");
            else richTextBox1.AppendText("Выбранная дата не совпадает с текущей\r");
        }

        private void changeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((changeTextBox.Text.Length != 0 && e.KeyChar == '-') || (changeTextBox.Text.IndexOf('-') != -1 && e.KeyChar == '-'))
            {
                e.Handled = true;   
                return;
            }
            else
            {
                return;
            }
            if ((changeTextBox.Text.Length == 0) && (e.KeyChar == ',' || e.KeyChar == '.'))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.') e.KeyChar = ',';
            if ((changeTextBox.Text.Length == 0 || changeTextBox.Text.IndexOf(',') != -1) && (e.KeyChar == ',' || e.KeyChar == '.'))
            {
                e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        nums[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                    else
                    {
                        MessageBox.Show("Не все ячейки содержат значение", "Ошибка!");
                        return;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j < i && nums[i, j] < 1.0)
                    {
                        nums[i, j] = Convert.ToDouble(changeTextBox.Text);
                    }
                    dataGridView2.Rows[i].Cells[j].Value = nums[i, j];
                }
            }
        }

        private void sortLinButton_Click(object sender, EventArgs e) // Сортировка линейным способом
        {
            int b = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        nums[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                    else
                    {
                        MessageBox.Show("Не все ячейки содержат значение", "Ошибка!");
                        return;
                    }
                }
            }

            DateTime linTimeStart = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                check = 0;
                while (check < N)
                {
                    for (int j = -1; j < N - 1; j++)
                    {
                        if (nums[i, j + 1] > nums[i, check])
                        {
                            temp = nums[i, check];
                            nums[i, check] = nums[i, j + 1];
                            nums[i, j + 1] = temp;
                        }
                    }
                    check++;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = nums[i, j];
                    b++; Thread.Sleep(5); // пауза
                }
            }
            DateTime linTimeEnd = DateTime.Now;

            lin = linTimeEnd.Subtract(linTimeStart);

            hLin = lin.Hours;
            mLin = lin.Minutes;
            sLin = lin.Seconds;
            msLin = lin.Milliseconds;

            richTextBox1.AppendText($"Время сортировки массива линейным методом: {hLin} часов {mLin} минут {sLin} секунд {msLin} миллисекунд\r");
        }

        private void sortBubbButton_Click(object sender, EventArgs e) // Сортировка методом пузырька
        {
            int b = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        nums[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                    else
                    {
                        MessageBox.Show("Не все ячейки содержат значение", "Ошибка!");
                        return;
                    }
                }
            }

            bubbTimeStart = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N - 1; k++)
                    {
                        if (nums[i, k] < nums[i, k + 1])
                        {
                            temp = nums[i, k];
                            nums[i, k] = nums[i, k + 1];
                            nums[i, k + 1] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = nums[i, j];
                    b++; Thread.Sleep(5); // пауза
                }
            }
            bubbTimeEnd = DateTime.Now;
            bubb = bubbTimeEnd.Subtract(bubbTimeStart);

            hBubb = bubb.Hours;
            mBubb = bubb.Minutes;
            sBubb = bubb.Seconds;
            msBubb = bubb.Milliseconds;

            richTextBox1.AppendText($"Время сортировки массива методом пузырька: {hBubb} часов {mBubb} минут {sBubb} секунд {msBubb} миллисекунд\r");
        }

        private void sortTimeButton_Click(object sender, EventArgs e)
        {
            if (sLin < sBubb) { hh = hLin; mm = mLin; ss = sLin; ss = sLin; fast = linFaster; }
            else { hh = hBubb; mm = mBubb; ss = sBubb; mss = msBubb; fast = bubbFaster; }
            if (sLin == sBubb) if (msLin < msBubb) { hh = hLin; mm = mLin; ss = sLin; mss = msLin; fast = linFaster; }
                else if (msLin > msBubb) { hh = hBubb; mm = mBubb; ss = sBubb; mss = msBubb; fast = bubbFaster; }
            richTextBox1.AppendText($"Способ сортировки {fast} самый быстрый, его время: {hh} часов {mm} минут {ss} секунд {mss} миллисекунд\r");
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        protected void OnTick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
