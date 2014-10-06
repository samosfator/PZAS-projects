using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMatrixStrings {
    class Matrix {
        private int[][] matrix;
        private int rows, cols;
        public Matrix(int[][] matrix) {
            this.matrix = matrix;
            this.cols = matrix[0].Length;
            this.rows = matrix.Length;
        }

        public int CountNotNullColumns() {
            int count = 0;

            for (int i = 0; i < cols; i++) {
                for (int j = 0; j < rows; j++) {
                    if (matrix[j][i] == 0) {
                        count++;
                        Console.WriteLine("Колонка " + (i + 1) + " має нульовий елемент");
                    }
                }
            }

            return count;
        }

        public void Sort() {
            int[] UnsortedCharacteristic = new int[rows];
            int[] SortedCharacteristic = new int[rows];
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    UnsortedCharacteristic[i] += matrix[i][j];
                }
            }
            Array.Copy(UnsortedCharacteristic, SortedCharacteristic, rows);
            Array.Sort(SortedCharacteristic);

            foreach (int i in SortedCharacteristic) Console.WriteLine(i);

            for (int i = 0; i < rows; i++) {
                if (!UnsortedCharacteristic[i].Equals(SortedCharacteristic[i])) swap(i, Array.IndexOf(SortedCharacteristic, UnsortedCharacteristic[i]));
            }
        }

        private void swap(int rowIndex, int destinationIndex) {
            int[] currentRow = new int[cols];
            int[] destRow = new int[cols];

            for (int i = 0; i < cols; i++) {
                currentRow[i] = matrix[rowIndex][i];
                destRow[i] = matrix[destinationIndex][i];
            }

            for (int i = 0; i < cols; i++) {
                
            }

        }
    }
}
