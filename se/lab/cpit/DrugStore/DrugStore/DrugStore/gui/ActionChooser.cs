using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrugStore.gui {
    public partial class ActionChooser : Form {
        private const int MinTextLength = 4;
        private const int MaxPrice = 999999;
        private static readonly Color ValidColor = Color.Chartreuse;
        private static readonly Color InvalidColor = Color.Crimson;
        public ActionChooser() {
            InitializeComponent();
            Database.FillDataGridView(dgv_drugsList);
        }

        protected override void OnClosed(EventArgs e) {
            Hide();
            Program.AuthForm.Show();
        }

        private static void SuccessMessage(Label label, string text) {
            label.ForeColor = ValidColor;
            label.Text = text;
        }

        private static void ErrorMessage(Label label, string text) {
            label.ForeColor = InvalidColor;
            label.Text = text;
        }

        private void EraseTextFields() {
            tb_addTitle.Text = "";
            tb_addType.Text = "";
            tb_addQuantity.Text = "";
            tb_addPrice.Text = "";
            tb_addDescr.Text = "";
            lbl_check_title.Text = "";
            lbl_check_type.Text = "";
            lbl_check_quantity.Text = "";
            lbl_check_price.Text = "";
        }

        private new bool Validate() {
            if (lbl_check_title.ForeColor.Equals(InvalidColor) ||
                lbl_check_type.ForeColor.Equals(InvalidColor) ||
                lbl_check_quantity.ForeColor.Equals(InvalidColor) ||
                lbl_check_price.ForeColor.Equals(InvalidColor)) {
                ErrorMessage(lbl_add_success, "Будь-ласка, введіть дані корректно!");
                return false;
            }
            return true;
        }

        private void btn_addDrug_Click(object sender, EventArgs e) {
            if (!Validate()) return; 
            var drug = new Drug {
                Title = tb_addTitle.Text,
                Type = tb_addType.Text,
                Description = tb_addDescr.Text,
                Quantity = Convert.ToInt32(tb_addQuantity.Text),
                Price = Convert.ToDouble(tb_addPrice.Text)
            };
            if (Database.AddDrugEntry(drug)) {
                SuccessMessage(lbl_add_success, "Успішно додано!");
                EraseTextFields();
            } else ErrorMessage(lbl_add_success, "Помилка при додаванні у базу");
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
            var valid = int.TryParse(text, out quantity) && (quantity < MaxPrice);
            if (valid) {
                SuccessMessage(lbl_check_quantity, "Все у нормі");
            } else ErrorMessage(lbl_check_quantity, "Введіть ціле число");
        }

        private void tb_addPrice_TextChanged(object sender, EventArgs e) {
            var text = tb_addPrice.Text;
            double price;
            var valid = double.TryParse(text, out price) && (price < MaxPrice);
            if (valid) {
                SuccessMessage(lbl_check_price, "Все у нормі");
            } else if (text.Contains(".")) {
                ErrorMessage(lbl_check_price, "Змініть крапку на кому");
            } else ErrorMessage(lbl_check_price, "Введіть числове значення");
        }

        private void btn_reloadTable_Click(object sender, EventArgs e) {
            dgv_drugsList.DataSource = null;
            Database.FillDataGridView(dgv_drugsList);
        }

        private void tb_del_title_TextChanged(object sender, EventArgs e) {

        }
    }
}
