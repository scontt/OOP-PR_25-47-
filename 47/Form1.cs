using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using static Pr47.Form1;

namespace Pr47
{
    public partial class Form1 : Form
    {
        Concert bob = new Concert();
        List<Concert> concert = new List<Concert>();//список объектов класса


        XmlSerializer formatter = new XmlSerializer(typeof(List<Concert>)); // сериализатор
        static int dgod, dmes, ddan, dh, dmin, dsek;
        string ss;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tt = new DateTime(); // создание объекта дата-время
            tt = System.DateTime.Now; // текущие дата и время
            double dan = date.Subtract(tt).TotalDays; // разность дней события от текущей даты
            double h = date.Subtract(tt).TotalHours; // разность часов события от текущего времени
            double min = date.Subtract(tt).TotalMinutes; // разность минут события от текущего времени
            int dan1 = (int)dan; // количество дней
            int h1 = (int)h - (dan1 * 24); // количество часов
            int min1 = (int)min - (int)h * 60; // количество минут
                                               // вывод в statusStrip количества дней, часов и минут, оставшихся до события

            label4.Text = "Осталось " + dan1.ToString() + " дней, " + h1.ToString() + " часов, " + min1.ToString()
            + " минут! до события: " + ss;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            concert.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            using (FileStream fs = new FileStream("../../File.xml", FileMode.Create)) // открытие файла
            {
                formatter.Serialize(fs, concert); // серилизация
            }
            int or = 0;
            foreach (Concert Bulka in concert) // сформировать список
            {
                listBox1.Items.Add($"{concert[or].Name} {concert[or].Date} {concert[or].Time}");
                or++;
            }
        }

        DateTime date; // дата и время события
        public Form1()
        {
            InitializeComponent();
            using (FileStream fs = new FileStream("../../File.xml", FileMode.OpenOrCreate)) // открытие файла
            {
                fs.Position = 0;
                concert = formatter.Deserialize(fs) as List<Concert>; // считать данные из файла в коллекцию (десериализация)
            }
            int or = 0;
            foreach (Concert Bulka in concert) // сформировать список
            {
                listBox1.Items.Add($"{concert[or].Name} {concert[or].Date} {concert[or].Time}");
                or++;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            bob.Name = textBox1.Text;
            bob.Date = maskedTextBox1.Text;
            bob.Time = maskedTextBox2.Text;
            concert.Add(bob);
            using (FileStream fs = new FileStream("../../File.xml", FileMode.OpenOrCreate)) // открытие файла
            {
                formatter.Serialize(fs, concert); // серилизация
            }
            listBox1.Items.Clear();
            concert.Clear();
            using (FileStream fs = new FileStream("../../File.xml", FileMode.OpenOrCreate)) // открытие файла
            {
                concert = formatter.Deserialize(fs) as List<Concert>; // считать данные из файла в коллекцию (десериализация)
            }
            int or = 0;
            foreach (Concert Bulka in concert) // сформировать список
            {
                listBox1.Items.Add($"{concert[or].Name} {concert[or].Date} {concert[or].Time}");
                or++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Stop(); // выключить таймер
            int z = listBox1.SelectedIndex; // индекс выбранной записи в списке
            if (z > -1)
            {
                ss = concert[z].Name; // название события из коллекции
                string s1 = concert[z].Date; // дата из коллекции (маска ввода dd.mm.yyyy)
                int k = s1.IndexOf('.'); // выделение из даты дня в переменную ddan
                string snam = s1.Substring(0, k).Trim(); s1 = s1.Remove(0, k + 1).Trim();
                if (snam[0] == '0') snam = snam.Remove(0, 1).Trim();
                ddan = Convert.ToInt32(snam.Trim());
                k = s1.IndexOf('.'); // выделение из даты месяца в переменную dmes
                snam = s1.Substring(0, k).Trim(); s1 = s1.Remove(0, k + 1).Trim();
                if (snam[0] == '0') snam = snam.Remove(0, 1).Trim();
                dmes = Convert.ToInt32(snam.Trim());
                snam = s1.Trim(); // выделение из даты года в переменную dgod
                if (snam[0] == '0') snam = snam.Remove(0, 1).Trim();
                dgod = Convert.ToInt32(snam.Trim());
                s1 = concert[z].Time; // время из коллекции (маска ввода hh:mm)
                k = s1.IndexOf(':'); // выделение из времени часов в переменную dh
                snam = s1.Substring(0, k).Trim(); s1 = s1.Remove(0, k + 1).Trim();
                if (snam[0] == '0') snam = snam.Remove(0, 1).Trim();
                dh = Convert.ToInt32(snam.Trim());
                snam = s1.Trim(); // выделение из времени минут в переменную dmin
                if (snam[0] == '0') snam = snam.Remove(0, 1).Trim();
                dmin = Convert.ToInt32(snam.Trim()); dsek = 0; // секунды
                date = new DateTime(dgod, dmes, ddan, dh, dmin, dsek); // даты: год - месяц - день - час - минута - секунда
                timer1.Tick += timer1_Tick; // вызов события через определенный интервал 
                timer1.Start(); // включить таймер

            }
        }

        [Serializable]
        public class Concert
        {
            public string Name { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }

        }
    }
}

