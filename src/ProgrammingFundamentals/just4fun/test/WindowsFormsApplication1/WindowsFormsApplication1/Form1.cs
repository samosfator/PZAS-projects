using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                totalSalary.Text = Convert.ToString(
                    Convert.ToDouble(rawSalary.Text) * 0.8);
            } catch (Exception) {
                totalSalary.Text = "0.0";
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void giftMoney_TextChanged(object sender, EventArgs e) {
            try {
                totalSalary.Text = Convert.ToString(
                    (Convert.ToDouble(rawSalary.Text) +
                        Convert.ToDouble(giftMoney.Text)) * 0.8);
            } catch (Exception) {
                textBox1_TextChanged(sender, e);
            }
        }
    }
}
