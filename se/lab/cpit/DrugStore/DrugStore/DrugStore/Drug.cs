using System.Drawing;

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
    }
}
