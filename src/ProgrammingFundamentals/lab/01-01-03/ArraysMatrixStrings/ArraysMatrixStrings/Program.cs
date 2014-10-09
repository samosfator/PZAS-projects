using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2nd variant
namespace ArraysMatrixStrings {
    class Program {
        public static void Main() {
            int[][] matrix = {
                                 new int[] {2, 24, 3, 0},
                                 new int[] {-1, 3, 0, 1},
                                 new int[] {3, -2, 12, 122}
                             };
            new Matrix(matrix).CountNotNullColumns();
            //double result = Arrays.MinMaxRangeMupltiply(new double[] { 10, -2, -23, 23, 23, -2, 3, -2, 222 });
            Console.Read();
        }
    }
}
