using System;
using System.Windows.Forms;
using DrugStore.gui;

namespace DrugStore {
    static class Program {
        public static Form AuthForm;
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AuthForm = new AuthWindow();
            Application.Run(AuthForm);
        }
    }
}
