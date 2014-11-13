using System;
using System.Data.OleDb;

namespace DrugStore {
    class Database {
        private const String DbPath = @"C:\Users\Vlad\IdeaProjects\pzas\se\lab\cpit\DrugStore\db.accdb";
        private readonly OleDbConnection _connection;

        public Database() {
            _connection = new OleDbConnection {
                ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DbPath + ";Persist Security Info=False;"
            };
        }

        public bool Auth(string username, string password) {
            var command = CreateQuery("select * from users where username='" +
                                username + "' and password='" + password + "'");
            using (_connection) {
                _connection.Open();
                var reader = command.ExecuteReader();
                return reader != null && reader.Read();
            }
        }

        private OleDbCommand CreateQuery(string query) {
            return new OleDbCommand {
                Connection = _connection,
                CommandText = query
            };
        }
    }
}
