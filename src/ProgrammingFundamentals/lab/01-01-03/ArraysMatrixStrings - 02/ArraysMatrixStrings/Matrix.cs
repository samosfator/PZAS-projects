using System;
using System.Linq;

namespace ArraysMatrixStrings {
    class Matrix {
        private readonly int[][] _matrix;
        private readonly int _rows, _cols;

        public Matrix(int[][] matrix) {
            _matrix = matrix;
            _cols = matrix[0].Length;
            _rows = matrix.Length;
        }

        public void GetNotNullColumns() {
            var count = 0;

            for (var i = 0; i < _cols; i++) {
                for (var j = 0; j < _rows; j++) {
                    if (_matrix[j][i] == 0) {
                        count++;
                        Console.WriteLine("Стовпець " + (i + 1) + " має нульовий елемент");
                    }
                }
            }
            Console.WriteLine("Задана матриця має: {0} ненульових стовпцi", _cols - count);
        }

        public void Sort() {
            Array.Sort(_matrix, (row1, row2) => CalcCharacteristic(row1).CompareTo(CalcCharacteristic(row2)));
            Console.WriteLine("Відсортована за характеристиками матриця: \n {0}", this);
        }

        private static int CalcCharacteristic(int[] row) {
            return row.Where(e => e > 0 && Array.IndexOf(row, e) % 2 == 0).Sum();
        }

        public override string ToString() {
            var str = "";
            foreach (var i in _matrix) {
                str = i.Aggregate(str, (current, next) => current + (next + ", "));
                str += "\n";
            }
            return str;
        }
    }
}
