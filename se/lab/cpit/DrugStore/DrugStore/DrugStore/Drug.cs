using System;
using System.Data.OleDb;

namespace DrugStore {
    class Drug {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public byte[] Picture { get; set; }

        public bool IsDup { get; set; }

        public Drug() {
        }

        public Drug(OleDbCommand command) {
            using (command) {
                command.Connection.Open();
                var reader = command.ExecuteReader();
                while (reader != null && reader.Read()) {
                    Title = reader["title"].ToString();
                    Type = reader["type"].ToString();
                    Quantity = Convert.ToInt32(reader["quantity"].ToString());
                    Price = Convert.ToDouble(reader["price"].ToString());
                    Description = reader["description"].ToString();
                    Picture = reader["picture"] as byte[];
                }
                reader.Close();
                reader.Dispose();
            }
        }

        public bool ParsePrice(string text) {
            double price;
            var okParse = double.TryParse(text, out price);
            Price = okParse ? double.Parse(text) : 0;
            return okParse;
        }
    }
}
