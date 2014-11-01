using System;
using System.Linq;

namespace ArraysMatrixStrings {
    class Matrix {
        private readonly int[][] _matrix;

        public Matrix(int[][] matrix) {
            _matrix = matrix;
        }

        public int GetNotNullRows() {
            var count = _matrix.Count(row => row.Count(el => el == 0) < 1);
            Console.WriteLine("Задана матриця має: {0} ненульових рядкiв", count);
            return count;
        }

        public double CountMaxOccurences() {
            var max = 0.0;
            var flatMatrix = _matrix.SelectMany(row => row).ToList();
            max = flatMatrix.First(el => flatMatrix.Count(i => i.Equals(el)) > 1 && el > max);
            Console.WriteLine("Максимальне число, що зустрiчається бiльше одного разу: {0}", max);
            return max;
        }
    }
}
