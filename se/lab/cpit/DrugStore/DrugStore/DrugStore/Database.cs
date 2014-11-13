using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DrugStore {
    static class Database {
        private const String DbPath = @"C:\Users\Vlad\IdeaProjects\pzas\se\lab\cpit\DrugStore\db.accdb";


        public static bool Auth(string username, string password) {
            var connection = NewConnection();
            var command = CreateCommand(connection, "SELECT * FROM users WHERE username='{0}' AND password='{1}'", username, password);
            using (command)
            using (connection) {
                connection.Open();
                var reader = command.ExecuteReader();
                return reader != null && reader.Read();
            }
        }

        public static void FillDataGridView(DataGridView dgv) {
            var connection = NewConnection();
            using (connection) {
                var dataAdapter = new OleDbDataAdapter(CreateCommand(connection, "SELECT * FROM drugs"));
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
        }

        private static OleDbConnection NewConnection() {
            return new OleDbConnection {
                ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DbPath + ";Persist Security Info=False;"
            };
        }

        private static OleDbCommand CreateCommand(OleDbConnection connection, string query, params object[] args) {
            return new OleDbCommand {
                Connection = connection,
                CommandText = String.Format(query, args)
            };
        }
    }
}
