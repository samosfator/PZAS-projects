using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DrugStore.gui;

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
                var dataAdapter = new OleDbDataAdapter(CreateCommand(connection, "SELECT * FROM drugs ORDER BY title"));
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
        }

        public static bool AddDrugEntry(Drug drug) {
            var command = CreateCommand(NewConnection(), "INSERT INTO drugs (title, type, quantity, price, description, picture) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', @Picture)",
                drug.Title, drug.Type, drug.Quantity, drug.Price, drug.Description);
            command.Parameters.AddWithValue("@Picture", drug.Picture);
            Console.WriteLine(command.CommandText);
            return ExecuteQuery(command) > 0;
        }

        public static bool CheckForDups(string title) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM drugs WHERE title='{0}'", title);
            return ReadAffected(command);
        }

        public static List<object> GetSearchTips(string title, string column) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM drugs WHERE title LIKE  \"" + title + "%\"");
            return ReadDb(command, column);
        }

        public static bool RemoveDrug(string title) {
            var command = CreateCommand(NewConnection(), "DELETE FROM drugs WHERE title='{0}'", title);
            return ExecuteQuery(command) > 0;
        }

        public static Drug GetDrug(string title) {
            var command = CreateCommand(NewConnection(), "SELECT * FROM drugs WHERE title='{0}'", title);
            return ReadDrug(command);
        }

        public static bool UpdateDrug(Drug drug) {
            var command = CreateCommand(NewConnection(), "UPDATE drugs SET type='{1}', quantity='{2}', price='{3}', description='{4}', picture=@Picture WHERE title='{0}'",
                drug.Title, drug.Type, drug.Quantity, drug.Price, drug.Description);
            command.Parameters.AddWithValue("@Picture", drug.Picture);
            return ExecuteQuery(command) > 0;
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
                Console.WriteLine(command.Connection.State);
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        private static List<object> ReadDb(OleDbCommand command, string column) {
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

        private static Drug ReadDrug(OleDbCommand command) {
            var drug = new Drug();
            using (command) {
                command.Connection.Open();
                var reader = command.ExecuteReader();
                while (reader != null && reader.Read()) {
                    drug.Title = reader["title"].ToString();
                    drug.Type = reader["type"].ToString();
                    drug.Quantity = Convert.ToInt32(reader["quantity"].ToString());
                    drug.Price = Convert.ToDouble(reader["price"].ToString());
                    drug.Description = reader["description"].ToString();
                    drug.Picture = reader["picture"] as byte[];
                }
            }
            return drug;
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
