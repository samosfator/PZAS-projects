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

        public int FindNegativeElements() {
            return _matrix.Where(row => Array.IndexOf(row, 0) > 0).Count(el => el.Count(e => e < 0) > 0);
        }

        public int AbsSumAfterFirstPositive() {
            var flatMatrix = _matrix.SelectMany(row => row).ToArray();
            var firstPosIndx = Array.IndexOf(flatMatrix, flatMatrix.First(el => el > 0));
            var sum = flatMatrix.Where(el => Array.IndexOf(flatMatrix, el) >= firstPosIndx).Sum();
            return sum;
        }
    }
}
