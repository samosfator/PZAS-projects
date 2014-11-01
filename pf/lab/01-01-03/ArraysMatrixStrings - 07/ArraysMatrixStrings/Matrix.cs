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

        public int FindSameColumnAndRow() {
            if (!_cols.Equals(_rows)) throw new ArgumentException("Неможливо порівняти рядки і стовпці: Матриця не квадратна");
            var k = -1;
            for (var i = 0; i < _rows; i++) {
                for (var j = 0; j < _cols; j++) {
                    if (_matrix[i][j].Equals(_matrix[j][i])) {
                        k = i;
                    }
                }
            }
            Console.WriteLine("{0}-ий рядок співпадає з {0}-им стовпцем цієї матриці ", k - 1);
            return k;
        }

        public int SumRowsWithNegativeElements() {
            return _matrix.Where(row => row.Count(el => el < 0) > 0).SelectMany(row => row).Sum();
        }
    }
}
