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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form ifrm1 = Application.OpenForms[0];
            ifrm1.Show(); // отобразить Form1
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pictureBox1_Click(sender, e);
        }
    }
}
