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
            richTextBox1.ReadOnly = true;
        }

        public Form2(Form1 f)
        {
            InitializeComponent();

            string[] listItems = { "Файл", "Главная", "Справка", "Курсив",
            "Полужирный", "Подчеркнутый", "Размер шрифта", "Найти слова", "Удалить слова", "Очистить поле"};
            listBox1.Items.AddRange(listItems);

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Файл" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Открывает выпадающее меню, в котором доступны элементы управления: Сохранить в файл, " +
                    "Открыть, Выход\n" +
                    "\nСохранить в файл - позволяет сохранить текст из поля в файл в формате .rtf\n" +
                    "Открыть - позволяет открыть текст из файла в формате .rtf и вывести его в поле ввода\n" +
                    "Выход - завершает работу программы";
            }
            if ("Главная" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Открывает выпадающее меню со всеми основными функциями программы.";
            }
            if ("Справка" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Открывает окно, которое содержит описание всех основных функций программы.";
            }
            if ("Курсив" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Позволяет изменить начертание текста на курсивный.";
            }
            if ("Полужирный" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Позволяет изменить начертание текста на полужирный.";
            }
            if ("Подчеркнутый" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Позволяет изменить начертание текста на подчеркнутый.";
            }
            if ("Размер шрифта" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Изменяет размер шрифта";
            }
            if ("Найти слова" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Осуществляет поиск слов, совпадающих с заданным.";
            }
            if ("Удалить слова" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Удаляет слова, содеражищие букву, которую ввёл пользователь.";
            }
            if ("Очистить поле" == listBox1.SelectedItem.ToString())
            {
                richTextBox1.Text = "Удаляет все символы из рабочего поля";
            }
        }
    }
}
