using System;
using System.Windows.Forms;

namespace DrugStore {
    public partial class ActionChooser : Form {
        public ActionChooser() {
            InitializeComponent();
            Database.FillDataGridView(dgv_drugsList);
        }

        protected override void OnClosed(EventArgs e) {
            Hide();
            Program.AuthForm.Show();
        }

        private void btn_addDrug_Click(object sender, EventArgs e) {
            var drug = new Drug {
                Title = tb_addTitle.Text,
                Type = tb_addType.Text,
                Description = tb_addDescr.Text,
                Quantity = Convert.ToInt32(tb_addQuantity.Text)
            };
            Database.AddDrugEntry(drug);
        }
    }
}
