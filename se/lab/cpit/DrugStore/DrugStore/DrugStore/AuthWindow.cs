using System;
using System.Windows.Forms;

namespace DrugStore {
    public partial class AuthWindow : Form {
        public AuthWindow() {
            InitializeComponent();
            statusStrip1.SizingGrip = false;
        }

        private void btn_signin_Click(object sender, EventArgs e) {
            statusbar.Text = "";
            var username = tb_login.Text;
            var password = tb_password.Text;
            var db = new Database();
            if (db.Auth(username, password)) {
                pb_loginSuccess.Increment(100);
                statusbar.Text = "Авторизація пройшла успішно";
            } else {
                statusbar.Text = "Неправильний логін / пароль";
            }
        }
    }
}
