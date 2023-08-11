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
        List<Processor> list = new List<Processor>();
        public Form1()
        {
            InitializeComponent();
            richTextBox.ReadOnly = true;
            comboBox.Items.AddRange(new string[] { "Фирма-производитель", "Наименование",
            "Цена", "Частота процессора", "Количество ядер", "Объем кэш-памяти"});
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Processor processor = new Processor();
            // Наполнение нового объекта данными
            processor.Company = companyTextBox.Text;
            processor.Name= nameTextBox.Text;
            processor.Price = Convert.ToDouble(priceTextBox.Text);
            processor.Frequency = Convert.ToInt32(frequencyTextBox.Text);
            processor.Cores = Convert.ToInt32(coresTextBox.Text);
            processor.Cache = Convert.ToInt32(cacheTextBox.Text);
            // Добавление объекта в listBox и в список list
            if (indexTextBox.Text.Length == 0)
            {
                listBox.Items.Add(processor.Frequency);
                list.Add(processor);
            }
            else
            {
                try
                {
                    listBox.Items.Insert(Convert.ToInt32(indexTextBox.Text) - 1, processor.Frequency);
                    list.Insert(Convert.ToInt32(indexTextBox.Text) - 1, processor);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show($"Выберите позицию не больше {list.Count + 1}", "Неверное значение");
                }
            }
            // Сброс значений текстбоксов
            companyTextBox.Text = default;
            nameTextBox.Text = default;
            priceTextBox.Text = default;
            frequencyTextBox.Text = default;
            coresTextBox.Text = default;
            cacheTextBox.Text = default;
            label9.Text = "Количество объектов в списке: " + list.Count();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Вывод сведений о выбранном процессоре
            try
            {
                richTextBox.Text = "Фирма-производитель: " + list[listBox.SelectedIndex].Company +
               "\r\nНаименование " + list[listBox.SelectedIndex].Name +
               "\r\nЦена: " + list[listBox.SelectedIndex].Price +
               "\r\nЧастота процессора: " + list[listBox.SelectedIndex].Frequency +
               "\r\nКоличество ядер: " + list[listBox.SelectedIndex].Cores +
               "\r\nОбъем кэш-памяти: " + list[listBox.SelectedIndex].Cache;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            // Ввод положения выбранного элемента в списке в indexTextBox
            companyTextBox.Text = list[listBox.SelectedIndex].Company;
            nameTextBox.Text = list[listBox.SelectedIndex].Name;
            priceTextBox.Text = list[listBox.SelectedIndex].Price.ToString();
            frequencyTextBox.Text = list[listBox.SelectedIndex].Frequency.ToString();
            coresTextBox.Text = list[listBox.SelectedIndex].Cores.ToString();
            cacheTextBox.Text = list[listBox.SelectedIndex].Cache.ToString();
            indexTextBox.Text = (listBox.SelectedIndex + 1).ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить элемент?", "Подтверждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Удаление элемента списка и listBox
                listBox.Items.RemoveAt(Convert.ToInt32(indexTextBox.Text) - 1);
                list.RemoveAt(Convert.ToInt32(indexTextBox.Text) - 1);
                // Сброс значений текстбоксов
                companyTextBox.Text = default;
                nameTextBox.Text = default;
                priceTextBox.Text = default;
                frequencyTextBox.Text = default;
                coresTextBox.Text = default;
                cacheTextBox.Text = default;
                indexTextBox.Text = default;
                richTextBox.Text = default;
                label9.Text = "Количество объектов в списке: " + list.Count();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            // Изменение сведений о процессоре (свойств класса Processor)
            try
            {
                list[Convert.ToInt32(indexTextBox.Text) - 1].Company = companyTextBox.Text;
                list[Convert.ToInt32(indexTextBox.Text) - 1].Name = nameTextBox.Text;
                list[Convert.ToInt32(indexTextBox.Text) - 1].Price = Convert.ToDouble(priceTextBox.Text);
                list[Convert.ToInt32(indexTextBox.Text) - 1].Frequency = Convert.ToInt32(frequencyTextBox.Text);
                list[Convert.ToInt32(indexTextBox.Text) - 1].Cores = Convert.ToInt32(coresTextBox.Text);
                list[Convert.ToInt32(indexTextBox.Text) - 1].Cache = Convert.ToInt32(cacheTextBox.Text);
                //Изменения названия элемента в listBox
                listBox.Items[Convert.ToInt32(indexTextBox.Text) - 1] = frequencyTextBox.Text;
                // Вывод измененных сведений о процессоре
                richTextBox.Text = "Фирма-производитель: " + list[listBox.SelectedIndex].Company +
                   "\r\nНаименование " + list[listBox.SelectedIndex].Name +
                   "\r\nЦена: " + list[listBox.SelectedIndex].Price +
                   "\r\nЧастота процессора: " + list[listBox.SelectedIndex].Frequency +
                   "\r\nКоличество ядер: " + list[listBox.SelectedIndex].Cores +
                   "\r\nОбъем кэш-памяти: " + list[listBox.SelectedIndex].Cache;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Объекта с выбранным номером не существует", "Ошибка");
            }
            catch (FormatException)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
        }

        private void indexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    listBox.SelectedIndex = Convert.ToInt32(indexTextBox.Text) - 1;
            //    return;
            //}
            //e.Handled = true;
        }

        private void indexTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //if (indexTextBox.Text.Length > 0 && ((listBox.Items.Count - Convert.ToInt32(indexTextBox.Text)) == 0 || (listBox.Items.Count - Convert.ToInt32(indexTextBox.Text)) == 1))
            //{
            //    listBox.SelectedIndex = Convert.ToInt32(indexTextBox.Text) - 1;
            //}
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "Фирма-производитель")
            {
                list.Sort((x, y) => x.Company.CompareTo(y.Company));
                for (int i = 0; i < list.Count; i++)
                {
                    listBox.Items[i] = list[i].Company;
                }
            }
            if (comboBox.SelectedItem.ToString() == "Наименование")
            {
                list.Sort((x, y) => x.Name.CompareTo(y.Name));
                for (int i = 0; i < list.Count; i++)
                {
                    listBox.Items[i] = list[i].Name;
                }
            }
            if (comboBox.SelectedItem.ToString() == "Цена")
            {
                list.Sort((x, y) => x.Price.CompareTo(y.Price));
                for (int i = 0; i < list.Count; i++)
                {
                    listBox.Items[i] = list[i].Price;
                }
            }
            if (comboBox.SelectedItem.ToString() == "Частота процессора")
            {
                list.Sort((x, y) => x.Frequency.CompareTo(y.Frequency));
                for (int i = 0; i < list.Count; i++)
                {
                    listBox.Items[i] = list[i].Frequency;
                }
            }
            if (comboBox.SelectedItem.ToString() == "Количество ядер")
            {
                list.Sort((x, y) => x.Cores.CompareTo(y.Cores));
                for (int i = 0; i < list.Count; i++)
                {
                    listBox.Items[i] = list[i].Cores;
                }
            }
            if (comboBox.SelectedItem.ToString() == "Объем кэш-памяти")
            {
                list.Sort((x, y) => x.Cache.CompareTo(y.Cache));
                for (int i = 0; i < list.Count; i++)
                {
                    listBox.Items[i] = list[i].Cache;
                }
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == ',' && priceTextBox.Text.Length > 0 && priceTextBox.Text.IndexOf(',') == -1) return;
            e.Handled = true;
        }
        private void digitsTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

    public class Processor
    {
        public string Company { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Frequency { get; set; }
        public int Cores { get; set; }
        public int Cache { get; set; }
    }
}
