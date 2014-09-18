using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button1.Text = System.DateTime.Today.Day + "." + System.DateTime.Today.Month + "." + System.DateTime.Today.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Путін редиска";
            button1.Enabled = false;
            MessageBox.Show("Не треба було натискати на цю кнопку!");
            button1.Text = "Героям Слава!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
