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
            if (offerSizeTextBox.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
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

        TrafficRules[] people = new TrafficRules[N];

        public Form1()
        {
            InitializeComponent();
            checkedListBox1.CheckOnClick = true;
            timePicker.ShowUpDown = true;
            Controls.Add(timePicker);
            richTextBox1.ReadOnly = true;
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            offenceType = "";
            people[j] = new TrafficRules();

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
            //time = timePicker.ToString();
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

            people[j].TrafficFill(name, gender, offenceType, phNum, date, drNum, carNum, time, offerSize);
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
                        people[i].Output(ref name, ref gender, ref offenceType, ref phNum, ref date, ref drNum, ref carNum, ref time, ref offerSize);
                        richTextBox1.Text += $"Имя: {name}\rПол: {gender}\rГос. номер автомобиля: {carNum}\rДата: {date}\r" +
                            $"Время: {time}\rВид нарушения: {offenceType}\rНомер телефона: {phNum}\rРазмер штрафа: {offerSize}\r";
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
        string nameT, genderT, phNumT, carNumT, dateT;
        int drNumT;
        string timeT;
        string offenceTypeT;
        double offerSizeT;

        public void TrafficFill(string name1, string gender1, string offenceType1, string phNum1, string date1, int drNum1, string carNum1, string time1, double offerSize1)
        {
            nameT = name1;
            genderT = gender1;
            offenceTypeT = offenceType1;
            phNumT = phNum1;
            dateT = date1;
            offerSizeT = offerSize1;
            drNumT = drNum1;
            timeT = time1;
            carNumT = carNum1;
        }

        public void Comparison(ref string par)
        {
            par = dateT.ToString();
        }

        public void Output(ref string name1, ref string gender1, ref string offenceType1, ref string phNum1, ref string date1, ref int drNum1, ref string carNum1, ref string time1, ref double offerSize1)
        {
            name1 = nameT;
            gender1 = genderT;
            offenceType1 = offenceTypeT;
            phNum1 = phNumT;
            date1 = dateT;
            drNum1 = drNumT;
            carNum1 = carNumT;
            time1 = timeT;
            offerSize1 = offerSizeT;
        }
    }
}
