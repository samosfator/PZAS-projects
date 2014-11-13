using System;
using System.Windows.Forms;

namespace DrugStore {
    public partial class AuthWindow : Form {
        public AuthWindow() {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e) {
            statusbar.Text = "";
            var username = tb_login.Text;
            var password = tb_password.Text;
            if (Database.Auth(username, password)) {
                statusbar.Text = "Авторизація пройшла успішно";
                Hide();
                new ActionChooser().Show();
            } else statusbar.Text = "Неправильний логін / пароль";
        }
    }
}
