using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DrugStore {
    static class Database {
        private const String DbPath = "db.accdb";

        public static bool Auth(string username, string password) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM users WHERE username='{0}' AND password='{1}'", username, password);
            return ReadAffected(command);
        }

        public static void LoadTable(DataGridView dgv) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM drugs ORDER BY title");
            using (command) {
                var dataAdapter = new OleDbDataAdapter(command);
                var dataTable = new DataTable();
                dataTable.DefaultView.AllowEdit = false;
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
                dgv.RowTemplate.Height = 30;
            }
        }

        public static bool AddDrug(Drug drug) {
            var command = CreateCommand(NewConnection(), "INSERT INTO drugs (title, type, quantity, price, description, picture) " +
                                                         "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', @Picture)",
                drug.Title, drug.Type, drug.Quantity, drug.Price, drug.Description);
            command.Parameters.AddWithValue("@Picture", drug.Picture);
            return ExecuteQuery(command) > 0;
        }

        public static bool UpdateDrug(Drug drug) {
            var command = CreateCommand(NewConnection(), "UPDATE drugs SET type='{1}', quantity='{2}', price='{3}', " +
                                                         "description='{4}' WHERE title='{0}'",
                drug.Title, drug.Type, drug.Quantity, drug.Price, drug.Description);
            return ExecuteQuery(command) > 0;
        }

        public static bool CheckForDups(string title) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM drugs WHERE title='{0}'", title);
            return ReadAffected(command);
        }

        public static List<object> GetSearchTips(string title, string column) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM drugs WHERE title LIKE  \"" + title + "%\"");
            return ReadColumn(command, column);
        }

        private static List<object> ReadColumn(OleDbCommand command, string column) {
            var result = new List<object>();
            using (command) {
                command.Connection.Open();
                var reader = command.ExecuteReader();
                while (reader != null && reader.Read()) {
                    result.Add(reader[column]);
                }
            }
            return result;
        }

        public static bool RemoveDrug(string title) {
            var command = CreateCommand(NewConnection(), "DELETE FROM drugs WHERE title='{0}'", title);
            return ExecuteQuery(command) > 0;
        }

        public static Drug GetDrug(string title) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM drugs WHERE title='{0}'", title);
            return new Drug(command);
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

        private static int ExecuteQuery(OleDbCommand command) {
            using (command) {
                command.Connection.Open();
                return command.ExecuteNonQuery();
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
