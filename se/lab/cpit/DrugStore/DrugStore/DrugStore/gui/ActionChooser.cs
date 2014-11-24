using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DrugStore.gui {
    public partial class ActionChooser : Form {
        private const int MinTextLength = 4;
        private const int MaxPrice = 999999;
        private static readonly Color ValidColor = Color.Chartreuse;
        private static readonly Color InvalidColor = Color.Crimson;
        private readonly Drug _newDrug = new Drug();
        public ActionChooser() {
            InitializeComponent();
            Database.FillDataGridView(dgv_drugsList);
            LoadSearchTips(lb_drug_list);
            LoadSearchTips(lb_delete_items);
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

        private bool ValidateNumFields() {
            if (lbl_check_type.ForeColor.Equals(InvalidColor) ||
                 lbl_check_quantity.ForeColor.Equals(InvalidColor) ||
                 lbl_check_price.ForeColor.Equals(InvalidColor)) {
                ErrorMessage(lbl_add_success, "Будь-ласка, введіть дані корректно!");
                return false;
            }
            return true;
        }

        private bool ValidateAdd() {
            if (_newDrug.IsDup) {
                ErrorMessage(lbl_add_success, "Такий препарат вже міститься у базі!");
                return false;
            }
            return ValidateNumFields();
        }

        private bool ValidateUpdate() {
            if (!_newDrug.IsDup) {
                ErrorMessage(lbl_add_success, "Виберіть існуючий препарат!");
                return false;
            }
            return ValidateNumFields();
        }

        private void LoadSearchTips(ListBox lbox) {
            var searchTips = Database.GetSearchTips(tb_del_title.Text, "title").ToArray();
            lbox.Items.Clear();
            lbox.Items.AddRange(searchTips);
        }

        private void btn_addDrug_Click(object sender, EventArgs e) {
            if (!ValidateAdd()) return;
            _newDrug.Description = tb_addDescr.Text;
            if (Database.AddDrugEntry(_newDrug)) {
                SuccessMessage(lbl_add_success, "Успішно додано!");
                EraseTextFields();
            } else ErrorMessage(lbl_add_success, "Помилка при додаванні у базу");
        }

        private void tb_addTitle_TextChanged(object sender, EventArgs e) {
            var title = _newDrug.Title = tb_addTitle.Text;
            if (Database.CheckForDups(title)) {
                _newDrug.IsDup = true;
                ErrorMessage(lbl_check_title, "Такий препарат вже міститься у базі!");
                btn_updateDrug.Enabled = true;
                btn_addDrug.Enabled = false;
            } else if (tb_addTitle.Text.Length < MinTextLength) {
                ErrorMessage(lbl_check_title, "Занадто коротка назва препарату");
            } else {
                _newDrug.IsDup = false;
                btn_updateDrug.Enabled = false;
                btn_addDrug.Enabled = true;
                SuccessMessage(lbl_check_title, "Все у нормі");
            }
        }

        private void tb_addType_TextChanged(object sender, EventArgs e) {
            _newDrug.Type = tb_addType.Text;
            if (_newDrug.Type.Length < MinTextLength) ErrorMessage(lbl_check_type, "Закоротка назва типу");
            else SuccessMessage(lbl_check_type, "Все у нормі");
        }

        private void tb_addQuantity_TextChanged(object sender, EventArgs e) {
            var text = tb_addQuantity.Text;
            int quantity;
            var valid = int.TryParse(text, out quantity) && (quantity < MaxPrice);
            if (valid) {
                _newDrug.Quantity = Convert.ToInt32(text);
                SuccessMessage(lbl_check_quantity, "Все у нормі");
            } else ErrorMessage(lbl_check_quantity, "Введіть ціле число");
        }

        private void tb_addPrice_TextChanged(object sender, EventArgs e) {
            var text = tb_addPrice.Text;
            double price;
            var valid = double.TryParse(text, out price) && (price < MaxPrice);
            if (valid) {
                _newDrug.Price = Convert.ToDouble(text);
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
            LoadSearchTips(lb_delete_items);
        }

        private void btn_delDrug_Click(object sender, EventArgs e) {
            var item = lb_delete_items.SelectedItem;
            if (item != null) {
                var drug = item.ToString();
                if (Database.RemoveDrug(drug)) {
                    SuccessMessage(lbl_delete_status, "Успішно видалено");
                } else ErrorMessage(lbl_delete_status, "Помилка видалення");
            } else ErrorMessage(lbl_delete_status, "Виберіть ліки для видалення");
        }

        private void lb_drug_list_SelectedIndexChanged(object sender, EventArgs e) {
            var drug = Database.GetDrug(lb_drug_list.SelectedItem.ToString());
            tb_addTitle.Text = drug.Title;
            tb_addType.Text = drug.Type;
            tb_addQuantity.Text = drug.Quantity.ToString();
            tb_addPrice.Text = drug.Price.ToString();
            tb_addDescr.Text = drug.Description;
            pictureBox1.Image = drug.Picture == null ? Image.FromStream(new MemoryStream(drug.Picture)) : null;
        }

        private void btn_updateDrug_Click(object sender, EventArgs e) {
            if (!ValidateUpdate()) return;
            if (Database.UpdateDrug(_newDrug)) {
                SuccessMessage(lbl_add_success, "Дані успішно онолено!");
                EraseTextFields();
            } else ErrorMessage(lbl_add_success, "Помилка при оновленні даних");
        }

        private void btn_reload_add_Click(object sender, EventArgs e) {
            LoadSearchTips(lb_drug_list);
        }

        private void btn_reload_del_Click(object sender, EventArgs e) {
            LoadSearchTips(lb_delete_items);
        }

        private void btn_addPicture_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog { Filter = "Зображення ліків (*.jpg)|*.jpg", FilterIndex = 1 };

            if (dialog.ShowDialog() == DialogResult.OK) {
                _newDrug.Picture = EncodePicture(dialog.FileName);
                Console.WriteLine(_newDrug.Picture.Length);
            }
        }

        private byte[] EncodePicture(string path) {
            var img = Image.FromFile(path);
            pictureBox1.Image = img;
            var memStream = new MemoryStream();
            pictureBox1.Image.Save(memStream, ImageFormat.Jpeg);
            return memStream.ToArray();
        }
    }
}
