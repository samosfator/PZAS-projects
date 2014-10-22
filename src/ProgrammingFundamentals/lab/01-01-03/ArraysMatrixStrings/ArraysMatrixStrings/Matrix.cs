using System;
using System.Linq;

namespace ArraysMatrixStrings {
    class Matrix {
        private readonly int[][] _matrix;
        private readonly int _rows, _cols;
        private int[] _unsortedCharacteristic, _sortedCharacteristic;

        public Matrix(int[][] matrix) {
            _matrix = matrix;
            _cols = matrix[0].Length;
            _rows = matrix.Length;
        }

        public int GetNotNullColumns() {
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

            return _cols - count;
        }

        public Matrix Sort() {
            CalcCharacteristic();
            for (var i = 0; i < _rows; i++) {
                if (!_unsortedCharacteristic[i].Equals(_sortedCharacteristic[i])) {
                    SwapRows(i, Array.IndexOf(_sortedCharacteristic, _unsortedCharacteristic[i]));
                    CalcCharacteristic();
                }
            }
            return this;
        }

        private void CalcCharacteristic() {
            _unsortedCharacteristic = new int[_rows];
            _sortedCharacteristic = new int[_rows];
            foreach (var row in _matrix) {
                _unsortedCharacteristic[Array.IndexOf(_matrix, row)] = row.Where(e => e > 0 && Array.IndexOf(row, e) % 2 == 0).Sum();
            }

            Array.Copy(_unsortedCharacteristic, _sortedCharacteristic, _rows);
            Array.Sort(_sortedCharacteristic);

            PrintCharacteristic();
        }

        private void SwapRows(int rowIndex, int destinationIndex) {
            var tempRow = new int[_cols];
            Array.Copy(_matrix[rowIndex], tempRow, _cols);
            Array.Copy(_matrix[destinationIndex], _matrix[rowIndex], _cols);
            Array.Copy(tempRow, _matrix[destinationIndex], _cols);
            Console.WriteLine("Swap {0} and {1} row", rowIndex, destinationIndex);
        }

        private void PrintCharacteristic() {
            Console.Write("Characteristic: ");
            foreach (var i in _unsortedCharacteristic) Console.Write(i + ", ");
            Console.WriteLine();
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
