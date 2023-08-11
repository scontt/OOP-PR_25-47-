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
        const int N = 10;
        int j = 0;
        int drNum;
        string name, gender, phNum, carNum, check, date, time, offenceType;
        double offerSize;
        TrafficRules[] people = new TrafficRules[N];

        public Form1()
        {
            InitializeComponent();
        }

        private void carNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void phNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+' && phNumTextBox.Text.Length == 0)
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void offerSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (offerSizeTextBox.Text.Length == 0 && (e.KeyChar == ',' || e.KeyChar == '.'))
            {
                e.Handled = true;
                return;
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
                return;
            }
            if (offerSizeTextBox.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
                return;
            }
            e.Handled = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nameTextBox.Text.Length == 0 && e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            time = timePicker.Value.ToLongTimeString();
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            offenceType = "";

            name = nameTextBox.Text;

            if (maleRadioButton.Checked)
            {
                gender = "Мужчина";
            }
            else if (femaleRadioButton.Checked)
            {
                gender = "Женщина";
            }

            carNum = carNumTextBox.Text;
            date = dateTimePicker1.Value.ToLongDateString();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (i == checkedListBox1.CheckedItems.Count - 1)
                {
                    offenceType += checkedListBox1.CheckedItems[i].ToString();
                }
                else
                {
                    offenceType += checkedListBox1.CheckedItems[i].ToString() + ", ";
                }
            }
            offenceType.Trim(',');
            phNum = phNumTextBox.Text;
            try
            {
                offerSize = Convert.ToDouble(offerSizeTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите размер штрафа!", "Ошибка");
                return;
            }

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (!outputComboBox.Items.Contains(date))
                {
                    outputComboBox.Items.Add(date);
                }
            }

            if (gender == "")
            {
                MessageBox.Show("Выберите пол!", "Ошибка");
                return;
            }
            if (carNumTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите гос. номер автомобиля!", "Ошибка");
                return;
            }
            if (phNumTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите мобильный номер нарушителя!", "Ошибка");
                return;
            }
            if (carNumTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите гос. номер автомобиля!", "Ошибка");
                return;
            }
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите вид нарушения", "Ошибка");
                return;
            }
            people[j] = new TrafficRules(ref name, ref gender, ref offenceType, ref phNum, ref date, ref drNum, ref carNum, ref time, ref offerSize);
            j++;

            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetSelected(i, false);
            }
            nameTextBox.Text = string.Empty;
            carNumTextBox.Text = string.Empty;
            phNumTextBox.Text = string.Empty;
            offerSizeTextBox.Text = string.Empty;
            gender = "";
        }

        private void outputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            try
            {
                for (int i = 0; i < N; i++)
                {
                    people[i].Comparison(ref check);
                    if (check == outputComboBox.SelectedItem.ToString())
                    {
                        richTextBox1.Text += $"Имя: {people[i].Name}\rПол: {people[i].Gender}\r" +
                            $"Гос. номер автомобиля: {people[i].CarNum}\rДата: {people[i].Date}\r" +
                            $"Время: {people[i].Time}\rВид нарушения: {people[i].OffenceType}\r" +
                            $"Номер телефона: {people[i].PhNum}\rРазмер штрафа: {people[i].OfferSize}\r";
                        richTextBox1.AppendText("\r");
                    }
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

    public class TrafficRules
    {
        string name, gender, phNum, carNum, date, time, offenceType;
        double offerSize;
        int drNum;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender 
        {
            get { return gender; }
            set { gender = value; } 
        }
        public string PhNum
        {
            get { return phNum; }
            set { phNum = value; }
        }
        public string CarNum 
        {
            get { return carNum; }
            set { carNum = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public string OffenceType
        {
            get { return offenceType; }
            set { offenceType = value; }
        }
        public double OfferSize
        {
            get { return offerSize; }
            set { offerSize = value; }
        }
        public int DrNum
        {
            get { return drNum; }
            set { drNum = value; }
        }

        public TrafficRules(ref string name1, ref string gender1, ref string offenceType1, ref string phNum1, ref string date1, ref int drNum1, ref string carNum1, ref string time1, ref double offerSize1)
        {
            Name = name1;
            Gender = gender1;
            PhNum = phNum1;
            CarNum = carNum1;
            Date = date1;
            Time = time1;
            OffenceType = offenceType1;
            OfferSize = offerSize1;
            DrNum = drNum1;
        }

        public void Comparison(ref string par)
        {
            par = Date;
        }
    }
}
