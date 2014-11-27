using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DrugStore.gui {
    public partial class ActionChooser : Form {
        private static readonly Color ValidColor = Color.LightGreen;
        private static readonly Color InvalidColor = Color.Crimson;
        private static bool ActionRecently;
        private readonly Drug _newDrug = new Drug();
        //Паттерн "Одинак" (Синглтон)
        private static ActionChooser _instance;
        private ActionChooser() {
            InitializeComponent();
            Database.LoadTable(dgv_drugsList);
            LoadSearchTips(lb_drug_list);
            dgv_drugsList.RowHeadersVisible = false;
        }
        public static ActionChooser Instance {
            get {
                if (_instance == null || _instance.IsDisposed) {
                    _instance = new ActionChooser();
                }
                return _instance;
            }
        }

        private void btn_addDrug_Click(object sender, EventArgs e) {
            if (!ValidateAdd()) return;
            ActionRecently = true;
            if (Database.AddDrug(_newDrug)) {
                SuccessMessage("Успішно додано!");
                EraseTextFields();
            } else ErrorMessage("Помилка при додаванні у базу");
        }

        private void tb_addTitle_TextChanged(object sender, EventArgs e) {
            var title = _newDrug.Title = tb_addTitle.Text;
            if (!ActionRecently) {
                if (Database.CheckForDups(title)) {
                    ErrorMessage(tb_addTitle, "Дублікат!");
                    _newDrug.IsDup = true;
                    btn_updateDrug.Enabled = true;
                    btn_addDrug.Enabled = false;
                    btn_addPicture.Enabled = false;
                } else if (_newDrug.Title.Length < 3) {
                    ErrorMessage(tb_addTitle, "Коротка назва препарату");
                } else {
                    _newDrug.IsDup = false;
                    btn_updateDrug.Enabled = false;
                    btn_addDrug.Enabled = true;
                    btn_addPicture.Enabled = true;
                    SuccessMessage(tb_addTitle, "Все у нормі");
                }
            } else ActionRecently = false;
        }

        private void tb_addType_TextChanged(object sender, EventArgs e) {
            _newDrug.Type = tb_addType.Text;
            if (!ActionRecently) {
                if (_newDrug.Type.Length >= 3) SuccessMessage(tb_addType, "Все у нормі");
                else if (_newDrug.Type.Length > 0) ErrorMessage(tb_addType, "Закоротка назва типу");
            } else ActionRecently = false;
        }

        private void tb_addPrice_TextChanged(object sender, EventArgs e) {
            if (!ActionRecently) {
                if (tb_addPrice.Text.Length > 0 && _newDrug.ParsePrice(tb_addPrice.Text)) {
                    SuccessMessage(tb_addPrice, "Все у нормі");
                } else if (tb_addPrice.Text.Contains(".")) {
                    ErrorMessage(tb_addPrice, "Змініть крапку на кому");
                } else if (tb_addPrice.Text.Length > 0) ErrorMessage(tb_addPrice, "Введіть числове значення");
            } else ActionRecently = false;
        }

        private void btn_reloadTable_Click(object sender, EventArgs e) {
            dgv_drugsList.DataSource = null;
            Database.LoadTable(dgv_drugsList);
        }

        private void lb_drug_list_SelectedIndexChanged(object sender, EventArgs e) {
            if (lb_drug_list.SelectedItem == null) return;
            var drug = Database.GetDrug(lb_drug_list.SelectedItem.ToString());
            tb_addTitle.Text = drug.Title;
            tb_addType.Text = drug.Type;
            num_quantity.Value = new decimal(drug.Price);
            tb_addPrice.Text = drug.Price.ToString();
            tb_addDescr.Text = drug.Description;
            pictureBox1.Image = drug.Picture != null ? Image.FromStream(new MemoryStream(drug.Picture)) : null;
        }

        private void btn_updateDrug_Click(object sender, EventArgs e) {
            try {
                if (Database.UpdateDrug(_newDrug)) {
                    SuccessMessage("Дані успішно онолено!");
                    ActionRecently = true;
                    EraseTextFields();
                } else ErrorMessage("Помилка при оновленні даних");
            } catch (Exception) {
                ErrorMessage("Помилка при оновленні даних");
            }
        }

        private void btn_addPicture_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog { Filter = "Зображення ліків (*.jpg)|*.jpg", FilterIndex = 1 };
            if (dialog.ShowDialog() == DialogResult.OK) {
                _newDrug.Picture = EncodePicture(dialog.FileName);
                Console.WriteLine(_newDrug.Picture.Length);
            } else {
                _newDrug.Picture = EncodePicture("square.jpg");
                Console.WriteLine(_newDrug.Picture.Length);
            }
        }

        private static byte[] EncodePicture(string path) {
            var memStream = new MemoryStream();
            Image.FromFile(path).Save(memStream, ImageFormat.Jpeg);
            return memStream.ToArray();
        }

        private void btn_delDrug_Click_1(object sender, EventArgs e) {
            var item = lb_drug_list.SelectedItem;
            if (item != null) {
                var drug = item.ToString();
                if (Database.RemoveDrug(drug)) {
                    SuccessMessage("Успішно видалено");
                } else ErrorMessage("Помилка видалення");
            } else ErrorMessage("Виберіть ліки для видалення");
        }

        private void tb_filter_TextChanged(object sender, EventArgs e) {
            LoadSearchTips(lb_drug_list);
        }

        private void btn_reload_add_Click(object sender, EventArgs e) {
            LoadSearchTips(lb_drug_list);
        }

        private void num_quantity_ValueChanged(object sender, EventArgs e) {
            _newDrug.Quantity = (int)num_quantity.Value;
        }

        private void SuccessMessage(TextBox tb, string text) {
            tb.BackColor = ValidColor;
            status_lbl.ForeColor = ValidColor;
            status_lbl.Text = text;
        }

        private void ErrorMessage(TextBox tb, string text) {
            tb.BackColor = InvalidColor;
            status_lbl.ForeColor = InvalidColor;
            status_lbl.Text = text;
        }

        private void SuccessMessage(string text) {
            status_lbl.ForeColor = ValidColor;
            status_lbl.Text = text;
        }

        private void ErrorMessage(string text) {
            status_lbl.ForeColor = InvalidColor;
            status_lbl.Text = text;
        }

        private void EraseTextFields() {
            tb_addTitle.Text = "";
            tb_addTitle.BackColor = Color.White;
            tb_addType.Text = "";
            tb_addType.BackColor = Color.White;
            num_quantity.Value = 0;
            tb_addPrice.Text = "";
            tb_addPrice.BackColor = Color.White;
            tb_addDescr.Text = "";
        }

        private bool ValidateAdd() {
            if (_newDrug.IsDup) {
                ErrorMessage(tb_addTitle, "Дублікат!");
                return false;
            }
            return ValidateNumFields();
        }

        private bool ValidateNumFields() {
            if (status_lbl.ForeColor == InvalidColor) return false;
            if (_newDrug.Picture == null) _newDrug.Picture = EncodePicture("square.jpg");
            return true;
        }

        private void LoadSearchTips(ListBox lbox) {
            var searchTips = Database.GetSearchTips(tb_filter.Text, "title").ToArray();
            lbox.Items.Clear();
            lbox.Items.AddRange(searchTips);
        }

        protected override void OnClosed(EventArgs e) {
            Hide();
            Program.AuthForm.Show();
        }

        private void tb_addDescr_TextChanged(object sender, EventArgs e) {
            _newDrug.Description = tb_addDescr.Text;
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        } 
    }
}
