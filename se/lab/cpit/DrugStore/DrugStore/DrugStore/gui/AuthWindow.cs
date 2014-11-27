using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrugStore.gui {
    public partial class AuthWindow : Form {
        public AuthWindow() {
            InitializeComponent();

            tb_password.KeyDown += (sender, args) => {
                if (tb_login.Text.Length > 1) LoginClick(args);
            };
            tb_login.KeyDown += (sender, args) => {
                if (tb_password.Text.Length > 1) LoginClick(args);
            };

            groupBox2.BackColor = Color.FromArgb(128, Color.Gold);
        }

        private void LoginClick(KeyEventArgs args) {
            if (args.KeyCode == Keys.Return) {
                btn_signin.PerformClick();
                args.SuppressKeyPress = true;
                args.Handled = true;
            }
        }

        private void btn_signin_Click(object sender, EventArgs e) {
            statusbar.Text = "";
            var username = tb_login.Text;
            var password = tb_password.Text;
            if (Database.Auth(username, password)) {
                statusbar.Text = "Авторизація пройшла успішно";
                Hide();
                ActionChooser.Instance.Show();
            } else statusbar.Text = "Неправильний логін / пароль";
        }
    }
}
