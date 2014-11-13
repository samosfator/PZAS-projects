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
    }
}
