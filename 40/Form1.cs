using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int z;
        string fileName = "",
             InitialDir = "";
        private string[] lines; // Переменные для печати
        private int linesPrinted;
        public Form1()
        {
            InitializeComponent();
            z = 0;
        }
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (z == 0)
            {
                descripRichTextBox.Focus();
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int indexNode = e.Node.Index; // Получить индекс выделенного элемента
            dig.DefaultExt = "*.rtf";
            // определить путь к каталогу Одежда, который находится в каталоге "C:..\WindowsFormsApp36"
            string dirrr = Directory.GetCurrentDirectory(); // путь к папке сисполняемым файлом "C:..\WindowsFormsApp36\bin\debug"
            int x = dirrr.LastIndexOf("\\"); // найти индекс последнего в строке символа \
            int y = dirrr.Length; // найти длину строки
            dirrr = dirrr.Remove(x, y - x); // удалить последний каталог
            x = dirrr.LastIndexOf("\\"); y = dirrr.Length;
            dirrr = dirrr.Remove(x, y - x); // удалить следующий последний каталог
                                            // теперь в переменной dirrr лежит путь к каталогу "C:..\WindowsFormsApp36"
            if (e.Node.Name == "windInstr")
            {
                OpenFileDialog dig = new OpenFileDialog();
                dig.InitialDirectory = dirrr + "\\Музыкальные инструменты\\Духовые";
            }
            if (e.Node.Name == "flute") descripRichTextBox.LoadFile("Музыкальные инструменты\\Духовые\\Флейта.rtf", 
                RichTextBoxStreamType.UnicodePlainText);
                //dig.InitialDirectory = dirrr + "\\Музыкальные инструменты\\Духовые\\Флейта.rtf";
            if (e.Node.Name == "clarinet") descripRichTextBox.LoadFile("Музыкальные инструменты\\Духовые\\Кларнет.rtf",
                RichTextBoxStreamType.UnicodePlainText);
            if (e.Node.Name == "oboe") descripRichTextBox.LoadFile("Музыкальные инструменты\\Духовые\\Гобой.rtf",
                RichTextBoxStreamType.UnicodePlainText);
            if (e.Node.Name == "stringsInstr") dig.InitialDirectory = dirrr + "\\Музыкальные инструменты\\Струнные";
            if (e.Node.Name == "lute") descripRichTextBox.LoadFile("Музыкальные инструменты\\Духовые\\Лютня.rtf",
                RichTextBoxStreamType.UnicodePlainText);
            if (e.Node.Name == "mandolin") descripRichTextBox.LoadFile("Музыкальные инструменты\\Духовые\\Мандолина.rtf",
                RichTextBoxStreamType.UnicodePlainText);
            if (e.Node.Name == "cello") descripRichTextBox.LoadFile("Музыкальные инструменты\\Духовые\\Виолончель.rtf",
                RichTextBoxStreamType.UnicodePlainText);
            if (e.Node.Name == "keysInstr") dig.InitialDirectory = dirrr + "\\Музыкальные инструменты\\Клавишные";
            if (e.Node.Name == "piano") dig.InitialDirectory = dirrr + "\\Музыкальные инструменты\\Клавишные\\Рояль";
            if (e.Node.Name == "organ") dig.InitialDirectory = dirrr + "\\Музыкальные инструменты\\Клавишные\\Орган";
            if (e.Node.Name == "fpiano") dig.InitialDirectory = dirrr + "\\Музыкальные инструменты\\Клавишные\\Фортепиано";
            InitialDir = dig.InitialDirectory; // запомнить каталог для возможного сохранения файлов
            dig.Filter = "Текстовые документы (*.rtf)|*.rtf|Все файлы|*.*";
            if (e.Node.Name != "Узел0")
                if (dig.ShowDialog() == DialogResult.OK && dig.FileName.Length > 0)
                { // открыть диалоговое окно выбора файла
                    descripRichTextBox.LoadFile(dig.FileName);
                }
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            if (dlgFont.ShowDialog() == DialogResult.OK) descripRichTextBox.Font = dlgFont.Font;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK) descripRichTextBox.ForeColor = dlgColor.Color;
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            descripRichTextBox.Clear();
        }

        private void pageButton_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pageSetupDialog1.PageSettings = new PageSettings();
            pageSetupDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left; int y = e.MarginBounds.Top;
            while (linesPrinted < lines.Length)
            { // каждая строка возвращается на принтер
                e.Graphics.DrawString(lines[linesPrinted++], new Font("Arial", 10), Brushes.Black, x, y);
                y += 15;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // метод PrintPage() должен быть вызван снова для печати другой страницы
                    return;
                }
            }
            linesPrinted = 0; e.HasMorePages = false; // печать только одной страницы
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = { '\n' };
            if (printDialog1.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.Selection)
            {
                lines = descripRichTextBox.SelectedText.Split(param);
            }
            else { lines = descripRichTextBox.Text.Split(param); }
            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines) lines[i++] = s.TrimEnd(trimParam);
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            lines = null;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (descripRichTextBox.SelectedText != "") printDialog1.AllowSelection = true;
                if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "" && descripRichTextBox.Text.IndexOf(searchTextBox.Text) > -1)
            {
                int n = descripRichTextBox.Find(searchTextBox.Text); // поиск индекса
                descripRichTextBox.Select(n, searchTextBox.Text.Length); // выбирает и выделяет диапазон текста
                descripRichTextBox.HideSelection = false; // чтобы выделение не пропадало при потере фокуса
                searchTextBox.Clear();
            }
            else { MessageBox.Show("Ничего не найдено"); }
            searchTextBox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "Текстовые документы (*.rtf)|*.rtf|Все файлы|*.*";
            sdlg.InitialDirectory = InitialDir;
            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                fileName = sdlg.FileName;
                try { File.WriteAllText(fileName, descripRichTextBox.Text); }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
