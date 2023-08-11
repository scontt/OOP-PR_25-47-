using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label1.Height = 0;
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            Font oldFont; Font newFont;
            oldFont = this.richTextBox1.SelectionFont;
            if (oldFont.Italic) newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            Font oldFont; Font newFont;
            oldFont = this.richTextBox1.SelectionFont;
            if (oldFont.Bold) newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            Font oldFont; Font newFont;
            oldFont = this.richTextBox1.SelectionFont;
            if (oldFont.Underline) newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void fontSizeButton_ButtonClick(object sender, EventArgs e)
        {

        }
        private void fontSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Удаление всех символов, не являющихся цифрами, символом забоя или клавишей <Enter>.
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            { // Применение размера, если пользователь нажимает клавишу <Enter>.
                ToolStripTextBox txt = (ToolStripTextBox)sender;
                if (txt.Text.Length > 0)
                {
                    float newSize = Convert.ToSingle(txt.Text); // Преобразование текста в плавающий тип.
                    FontFamily currentFontFamily;
                    Font newFont;
                    // Создание нового шрифта этого же семейства, но с новым размером.
                    currentFontFamily = this.richTextBox1.SelectionFont.FontFamily;
                    newFont = new Font(currentFontFamily, newSize);
                    this.richTextBox1.SelectionFont = newFont; // Установка нового шрифта в качестве шрифта выбранного текста.
                }
                e.Handled = true;
                this.richTextBox1.Focus();
            }
        }
        private void fontSizeTextBox_Validated(object sender, EventArgs e)
        {
            ToolStripTextBox txt = (ToolStripTextBox)sender;
            float newSize = Convert.ToSingle(txt.Text); // Преобразование текста в плавающий тип.
            FontFamily currentFontFamily;
            Font newFont;
            // Создание нового шрифта этого же семейства, но с новым размером.
            currentFontFamily = this.richTextBox1.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);
            this.richTextBox1.SelectionFont = newFont; // Установка нового шрифта в качестве шрифта выбранного текста.
            this.richTextBox1.Focus();
        }

        private void searchingWordTextBox_KeyPress(object sender, KeyPressEventArgs e) // Фокусировка на кнопку "Найти" по нажатию Enter
        {
            if(e.KeyChar == 13) searchButton.Select();
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void deleteWordTextBox_KeyPress(object sender, KeyPressEventArgs e) // Фокусировка на кнопку "Найти" по нажатию Enter
        {
            if (e.KeyChar == 13) deleteButton.Select();
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back) return;
            }
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if (deleteWordTextBox.Text.Length > 0)
            {
                e.Handled = true;
                return;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void mainFontSizeTextBox_Validated(object sender, EventArgs e)
        {
            ToolStripTextBox txt = (ToolStripTextBox)sender;
            float newSize = Convert.ToSingle(txt.Text); // Преобразование текста в плавающий тип.
            FontFamily currentFontFamily;
            Font newFont;
            // Создание нового шрифта этого же семейства, но с новым размером.
            currentFontFamily = this.richTextBox1.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);
            this.richTextBox1.SelectionFont = newFont; // Установка нового шрифта в качестве шрифта выбранного текста.
            this.richTextBox1.Focus();
        }

        private void mainSearchButton_Click(object sender, EventArgs e)
        {
            searchingWordTextBox.Text = mainSearchingWordTextBox.Text;
            this.searchButton_Click(sender, e);
        }

        private void mainDeleteButton_Click(object sender, EventArgs e)
        {
            deleteWordTextBox.Text = mainDeleteWordTextBox.Text;
            this.deleteButton_Click(sender, e);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SaveFile(@".\Text.rtf");
            }
            catch (System.Exception err) { MessageBox.Show(err.Message); }
            finally { MessageBox.Show("Успешно сохранено", "Сохранено"); }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(@".\Text.rtf");
            }
            catch (System.IO.FileNotFoundException) { MessageBox.Show("Файл не найден"); }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }
        private void richTextBox1_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchingWord = searchingWordTextBox.Text, stringNumber = "";
            string[] words;
            if (searchingWordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите слово в поле поиска", "Ошибка!");
                return;
            }
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Поле с текстом пустое", "Ошибка!");
                return;
            }
            else
            {
                for (int i = 0; i < richTextBox1.Lines.Length; i++)
                {
                    words = richTextBox1.Lines[i].Split(' '); // Разделение строки на слова
                    for (int j = 0; j < words.Length; j++)
                    {
                        words[j] = words[j].Trim(',');
                        if (words[j].ToLower() == searchingWord.ToLower()) // Определение строк с введенным словом
                        {
                            stringNumber += (i + 1).ToString() + ", "; // Занесение номеров строк со словом в stringNumber
                        }
                    }
                }
                if (richTextBox1.Lines.Count() != 0 && richTextBox1.Lines[richTextBox1.Lines.Count() - 1].Length != 0)
                {
                    richTextBox1.AppendText("\r"); // Переход на новую строку, если последняя содержит текст
                }
                if (stringNumber.Length == 0)
                {
                    richTextBox1.AppendText($"Строки со словом {searchingWord} не найдены" + "\r");
                }
                else
                {
                    stringNumber = stringNumber.Remove(stringNumber.LastIndexOf(',')); // Удаление последней запятой
                    if (stringNumber.Length == 1) richTextBox1.AppendText($"Номер строки со словом {searchingWord}: {stringNumber}\r");
                    else if (stringNumber.Length > 1) richTextBox1.AppendText($"Номера строк со словом {searchingWord}: {stringNumber}\r");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string formattedText = "",
                lineNums = "";
            string letter = deleteWordTextBox.Text;
            bool lineEmpty = false;

            int n = 0;

            string[] words;

            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                lineEmpty = false;
                n = 0;
                words = richTextBox1.Lines[i].Split(' ');
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Contains(letter))
                    {
                        words[j] = "";
                        n++;
                    }
                }
                if (n > 0)
                {
                    lineNums += (i + 1).ToString() + ", ";
                }
                if (!(n == words.Length))
                {
                    formattedText += String.Join(" ", words);
                    if (formattedText.LastIndexOf(' ') == formattedText.Length - 1)
                    {
                        formattedText.Trim();
                    }
                }
                else lineEmpty = true;
                if (!lineEmpty)
                {
                    formattedText += "\r";
                }
            }
            if (lineNums.IndexOf(',') != -1) lineNums = lineNums.Remove(lineNums.LastIndexOf(',')); // Удаление последней запятой в выводе номеров строк
            if (richTextBox1.Lines.Count() != 0 && richTextBox1.Lines[richTextBox1.Lines.Count() - 1].Length != 0)
            {
                richTextBox1.AppendText("\r"); // Переход на новую строку, если последняя содержит текст
            }
            richTextBox1.AppendText($"\rТекст без слов, содержащих букву {letter}: \r{formattedText}\r" +
                $"Номера строк, в которых было произведено удаление: {lineNums}");
        }

        private void openButton_Click_1(object sender, EventArgs e)
        {

        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}