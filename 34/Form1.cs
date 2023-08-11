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
        int[,] intArray;
        double[,] doubleArray;
        double[] intResultArray, doubleResultArray;
        int intX, intY;
        double doubleX, doubleY, avgF = 0;
        Overload av;
        private void createArrayButton_Click(object sender, EventArgs e)
        {
            if (intRadioButton.Checked && intArray == null)
            {
                createArrayButton.Enabled = false;
                deleteArrayButton.Enabled = true;

                intY = Convert.ToInt32(rowsTextBox.Text);
                intX = Convert.ToInt32(columnsTextBox.Text);
                intArray = new int[intY, intX];   // Создание целочисленного массива

                intResultArray = new double[intX];   // Создание массива для подсчета среднего значения

                arrayDataGridView.ColumnCount = intX; // Создание ячеек для заполнения и вывода массива и среднего значения
                arrayDataGridView.RowCount = intY;    //
                resultDataGridView.ColumnCount = intX;//
                
            }
            else if(doubleRadioButton.Checked && doubleArray == null)
            {
                createArrayButton.Enabled = false;
                deleteArrayButton.Enabled = true;

                doubleY = Convert.ToInt32(rowsTextBox.Text);
                doubleX = Convert.ToInt32(columnsTextBox.Text);
                doubleArray = new double[(int)doubleY, (int)doubleX];   // Создание вещественного массива

                doubleResultArray = new double[(int)doubleX];   // Создание массива для подсчета среднего значения

                arrayDataGridView.ColumnCount = (int)doubleX; // Создание ячеек для заполнения и вывода массива и среднего значения
                arrayDataGridView.RowCount = (int)doubleY;    //
                resultDataGridView.ColumnCount = (int)doubleX;//
            }
            for (int i = 0; i < arrayDataGridView.ColumnCount; i++)
            {
                arrayDataGridView.Columns[i].Width = 35;
                resultDataGridView.Columns[i].Width = 35;
            }
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            if (intRadioButton.Checked)
            {
                for (int stolb = 0; stolb < intX; stolb++)
                {
                    for (int stroka = 0; stroka < intY; stroka++)
                    {
                        try
                        {
                            intArray[stroka, stolb] =
                            Convert.ToInt32(arrayDataGridView.Rows[stroka].Cells[stolb].Value);   // Заполнение массива из arrayDataGridView (цел.)
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Вводите целые числа!", "Ошибка");
                        }
                        
                    }
                }
                av = new Overload(intArray);
                for (int stolb = 0; stolb < intX; stolb++)
                {
                    intResultArray[stolb] = av.AverageNum(stolb, intY);   // Подсчет средних значений (цел.)
                    resultDataGridView.Rows[0].Cells[stolb].Value = intResultArray[stolb]; // Вывод средних значений в resultDataGridView (цел.)
                }
            }
            else
            {
                for (int stolb = 0; stolb < doubleX; stolb++)
                {
                    for (int stroka = 0; stroka < doubleY; stroka++)
                    {
                        try
                        {
                            doubleArray[stroka, stolb] =
                            Convert.ToDouble(arrayDataGridView.Rows[stroka].Cells[stolb].Value);   // Заполнение массива из arrayDataGridView (вещ.)
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Вводите вещественные числа!", "Ошибка");
                        }
                    }
                }
                av = new Overload(doubleArray);
                for (int stolb = 0; stolb < (int)doubleX; stolb++)
                {
                    av.AverageNum(stolb, doubleY, ref avgF);
                    doubleResultArray[stolb] = avgF;   // Подсчет средних значений (вещ.)
                    resultDataGridView.Rows[0].Cells[stolb].Value = doubleResultArray[stolb];   // Вывод средних значений в resultDataGridView (вещ.)
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }

        private void deleteArrayButton_Click(object sender, EventArgs e)   // Очистка массивов
        {
            if (intRadioButton.Checked)
            {
                intArray = null;

                arrayDataGridView.Rows.Clear();
                resultDataGridView.Rows.Clear();

                createArrayButton.Enabled = true;
                deleteArrayButton.Enabled = false;
            }
            else if (doubleRadioButton.Checked)
            {
                doubleArray = null;

                arrayDataGridView.Rows.Clear();
                resultDataGridView.Rows.Clear();

                createArrayButton.Enabled = true;
                deleteArrayButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void intRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Включение кнопок
            createArrayButton.Enabled = true;
            rowsTextBox.Enabled = true;
            columnsTextBox.Enabled = true;
            averageButton.Enabled = true;
            //

            if (intRadioButton.Checked)
            {
                createArrayButton.Enabled = false;
                if (intArray == null)
                {
                    createArrayButton.Enabled = true;
                    arrayDataGridView.Rows.Clear();
                    resultDataGridView.Rows.Clear();
                    deleteArrayButton.Enabled = false;
                }
                else
                {
                    resultDataGridView.Rows.Clear();
                    arrayDataGridView.Rows.Clear();

                    // Возвращение количества ячеек сетки для вывода массива при измении выбора типа массива (цел.)
                    resultDataGridView.ColumnCount = intX;
                    arrayDataGridView.ColumnCount = intX;
                    arrayDataGridView.RowCount = intY;
                    //

                    for (int i = 0; i < intY; i++)
                    {
                        for (int j = 0; j < intX; j++)
                        {
                            arrayDataGridView.Rows[i].Cells[j].Value = intArray[i, j];   // Вывод введенного ранее массива (цел.)
                            resultDataGridView.Rows[0].Cells[j].Value = intResultArray[j];   // Вывод посчитанных средних значений (цел.)
                        }
                    }

                    deleteArrayButton.Enabled = true;
                }
            }
            else
            {
                createArrayButton.Enabled = false;
                if (doubleArray == null)
                {
                    // Включение кнопок
                    createArrayButton.Enabled = true;
                    arrayDataGridView.Rows.Clear();
                    resultDataGridView.Rows.Clear();
                    deleteArrayButton.Enabled = false;
                    //
                }
                else
                {
                    resultDataGridView.Rows.Clear();
                    arrayDataGridView.Rows.Clear();

                    // Возвращение количества ячеек сетки для вывода массива при измении выбора типа массива (вещ.)
                    resultDataGridView.ColumnCount = (int)doubleX;
                    arrayDataGridView.ColumnCount = (int)doubleX;
                    arrayDataGridView.RowCount = (int)doubleY;
                    //

                    for (int i = 0; i < doubleY; i++)
                    {
                        for (int j = 0; j < doubleX; j++)
                        {
                            arrayDataGridView.Rows[i].Cells[j].Value = doubleArray[i, j];   // Вывод введенного ранее массива (вещ.)
                            resultDataGridView.Rows[0].Cells[j].Value = doubleResultArray[j];   // Вывод посчитанных средних значений (вещ.)
                        }
                    }

                    deleteArrayButton.Enabled = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            arrayDataGridView.ColumnHeadersVisible = false;
            arrayDataGridView.RowHeadersVisible = false;
            createArrayButton.Enabled = false;
            rowsTextBox.Enabled = false;
            columnsTextBox.Enabled = false;
            averageButton.Enabled = false;
            arrayDataGridView.AllowUserToAddRows = false;
            arrayDataGridView.AllowUserToDeleteRows = false;
            deleteArrayButton.Enabled = false;
        }


    }
    
    public class Overload
    {
        int[,] ovIntArray;
        double[,] ovDoubleArray;
        double ovAvg;
        
        public Overload(double[,] array)
        {
            ovDoubleArray = array;
        }

        public Overload(int[,] array)
        {
            ovIntArray = array;
        }

        public double AverageNum(int cell, int row)
        {
            ovAvg = 0;
            //for (int i = cell; i == cell; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    ovAvg += ovIntArray[j, cell];
                }   
            }
            ovAvg /= row;
            return ovAvg;
        }

        public void AverageNum(double cell, double row, ref double avg)
        {
            ovAvg = 0;
            for (int i = (int)cell; i == cell; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    ovAvg += ovDoubleArray[j, i];
                }
            }
            ovAvg /= row;
            avg = ovAvg;
        }
    }
}
