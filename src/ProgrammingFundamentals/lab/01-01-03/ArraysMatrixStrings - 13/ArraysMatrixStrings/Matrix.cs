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

        public void CountRowsWithNullElement() {
            var count = _matrix.Count(row => row.Count(el => el == 0) > 0);
            Console.WriteLine("Задана матриця має: {0} нульових рядкiв", count);
        }

        public void ColumnWithMostSameEl() {
            var sameCounter = new int[_cols];
            for (int col = 0; col < _cols; col++) {
                for (int row = 0; row < _rows - 1; row++) {
                    if (_matrix[row][col].Equals(_matrix[row + 1][col])) {
                        sameCounter[col]++;
                    } else sameCounter[col] = 0;
                }
            }
            Console.Write("Номер стовпця з найдовшою серiєю однакових елементiв: ");
            Console.WriteLine(Array.IndexOf(sameCounter, sameCounter.Max()));
        }
    }
}
