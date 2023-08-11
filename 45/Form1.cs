using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        University univerDictionary = new University();
        public Form1()
        {
            InitializeComponent();
            richTextBox.ReadOnly = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0 && rectorTextBox.Text.Length > 0)
            {
                univerDictionary.Include(Convert.ToInt32(indexTextBox.Text), nameTextBox.Text, rectorTextBox.Text);
            }
            else MessageBox.Show("Заполните все поля!", "Ошибка");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int key;
            if (int.TryParse(indexTextBox.Text, out key))
            {
                univerDictionary.Delete(key, "");
            }
            else
            {
                string parameter = indexTextBox.Text;
                string value = $"Название ВУЗа: {parameter}, ФИО ректора: {rectorTextBox.Text}";
                univerDictionary.Delete(-1, value);
                univerDictionary.Check(value);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int key;
            if (int.TryParse(indexTextBox.Text, out key))
            {
                
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

        private void digitsTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            int key;
            string value;
            if (int.TryParse(indexTextBox.Text, out key))
            {
                univerDictionary.Search(key, out value);
                richTextBox.Text = value;
            }
            else
            {
                string parameter = searchTextBox.Text;
                //value = $"Название ВУЗа: {parameter}, ФИО ректора: {rectorTextBox.Text}";
                richTextBox.Text = univerDictionary.Search(parameter);
            }
            if (richTextBox.Text == "")
            {
                MessageBox.Show("Объекта не существует");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            richTextBox.Text = univerDictionary.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

    public class University
    {
        Dictionary<int, string> education = new Dictionary<int, string>();
        //string name, rector;

        public string Show() /// Метод для чтения сведений об объекте с индексом index
        {
            string allValues = "";
            foreach (int i in education.Keys)
            {
                allValues += $"Ключ: {i} | Значение: {education[i]}\r\n";
            }
            return allValues;
        }
        public void Include(int key, string name, string rector) /// Метод для добавления нового объекта в словарь
        {
            education.Add(key, $"Название ВУЗа: {name}, ФИО ректора: {rector}");
        }
        public void Change(int key, string value, string rpmnt)
        {
            if (education.ContainsKey(key)) // Поиск ключа в словаре
            {
                education[key] = rpmnt;
                return;
            }
            if (value != "")
            {

            }
        }
        public void Delete(int key, string value) /// Метод для удаления объектов словаря
        {
            if (education.ContainsKey(key)) // Поиск ключа в словаре
            {
                education.Remove(key);
                return;
            }
            foreach (int i in education.Keys)
            {
                if (education[i].Substring(15, value.Length) == value) education.Remove(i);
                else if (education[i].Substring(education[i].LastIndexOf(':') + 2, value.Length) == value) education.Remove(i);
            }

            //if (value != "")
            //{
            //    int mKey = 0;
            //    foreach (int k in education.Keys)
            //    {
            //        if (education[k].Equals(value))
            //        {
            //            mKey = k;
            //        }
            //    }
            //    education.Remove(mKey);
            //    return;
            //}
        }
        public void Search(int key, out string text)
        {
            education.TryGetValue(key, out text);
        }
        public string Search(string value)
        {
            foreach (int k in education.Keys)
            {
                if (education[k].Equals(value)) 
                {
                    return education[k]; // Получение ключа объекта по значению
                }
                if (education[k].Substring(15, value.Length) == value) return education[k];
                else if (education[k].Substring(education[k].LastIndexOf(':') + 2, value.Length) == value) return education[k];
            }
            return "";
        }
        public void Check(string value) /// Метод проверки после удаления объекта
        {
            if (!education.ContainsValue(value))
            {
                MessageBox.Show("Объект успешно удален");
            }
        }
    }
}
