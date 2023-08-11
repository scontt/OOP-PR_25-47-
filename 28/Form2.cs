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
            label1.Text = "Программа позволяет пользователю заполнить двумерный массив вещественных чисел, заменить в нем числа меньше 1 под главной диагональю" +
                ", отсортировать его двумя способами и сравнить время сортировки массива этими методами.\n" +
                "Также программа позволяет проверить текущую дату.";
        }
    }
}
