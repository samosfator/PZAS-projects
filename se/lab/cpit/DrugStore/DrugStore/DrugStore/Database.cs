using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DrugStore {
    static class Database {
        private const String DbPath = @"C:\Users\Vlad\IdeaProjects\pzas\se\lab\cpit\DrugStore\db.accdb";


        public static bool Auth(string username, string password) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM users WHERE username='{0}' AND password='{1}'", username, password);
            return ReadAffected(command);
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

        public static void AddDrugEntry(Drug drug) {
            var command = CreateCommand(NewConnection(), "INSERT INTO drugs (title, type, quantity, price, description) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                drug.Title, drug.Type, drug.Quantity, drug.Price, drug.Description);
            ExecuteQuery(command);
        }

        public static bool CheckForDups(string title) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM drugs WHERE title='{0}'", title);
            return ReadAffected(command);
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

        private static void ExecuteQuery(OleDbCommand command) {
            using (command) {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private static bool ReadAffected(OleDbCommand command) {
            using (command) {
                command.Connection.Open();
                var reader = command.ExecuteReader();
                return reader != null && reader.Read();
            }
        }
    }
}
