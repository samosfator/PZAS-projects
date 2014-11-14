using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrugStore.gui {
    public partial class ActionChooser : Form {
        private const int MinTextLength = 4;
        public ActionChooser() {
            InitializeComponent();
            Database.FillDataGridView(dgv_drugsList);
        }

        protected override void OnClosed(EventArgs e) {
            Hide();
            Program.AuthForm.Show();
        }

        private void SuccessMessage(Label label, string text) {
            label.ForeColor = Color.Chartreuse;
            label.Text = text;
        }

        private void ErrorMessage(Label label, string text) {
            label.ForeColor = Color.Crimson;
            label.Text = text;
        }

        private void btn_addDrug_Click(object sender, EventArgs e) {
            var drug = new Drug {
                Title = tb_addTitle.Text,
                Type = tb_addType.Text,
                Description = tb_addDescr.Text,
                Quantity = Convert.ToInt32(tb_addQuantity.Text),
                Price = Convert.ToDouble(tb_addPrice.Text)
            };
            Database.AddDrugEntry(drug);
        }

        private void tb_addTitle_TextChanged(object sender, EventArgs e) {
            var title = tb_addTitle.Text;
            if (Database.CheckForDups(title)) {
                ErrorMessage(lbl_check_title, "Такий препарат вже міститься у базі!");
            } else if (tb_addTitle.Text.Length < MinTextLength) {
                ErrorMessage(lbl_check_title, "Занадто коротка назва препарату");
            } else SuccessMessage(lbl_check_title, "Все у нормі");
        }

        private void tb_addType_TextChanged(object sender, EventArgs e) {
            if (tb_addType.Text.Length < MinTextLength) ErrorMessage(lbl_check_type, "Закоротка назва типу");
            else SuccessMessage(lbl_check_type, "Все у нормі");
        }

        private void tb_addQuantity_TextChanged(object sender, EventArgs e) {
            var text = tb_addQuantity.Text;
            int quantity;
            var valid = int.TryParse(text, out quantity);
            if (valid) {
                SuccessMessage(lbl_check_quantity, "Все у нормі");
            } else ErrorMessage(lbl_check_quantity, "Введіть ціле число");
        }
    }
}
