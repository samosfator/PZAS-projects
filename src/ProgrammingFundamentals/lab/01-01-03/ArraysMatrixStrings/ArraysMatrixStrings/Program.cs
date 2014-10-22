using System;

//2nd variant
namespace ArraysMatrixStrings {
    class Program {
        public static void Main() {
            int[][] matrix = {
                                 new[] {21, 24, 3, 0},
                                 new[] {-1, 23, 0, 1},
                                 new[] {32, -2, 112, 122}
                             };
            //Console.WriteLine(new Matrix(matrix).Sort());
            Console.WriteLine(new Matrix(matrix).GetNotNullColumns());

            //Arrays.MultiplyMinMaxRange(new double[] { 10, -2, -23, 23, 23, -2, 3, -2, 222 });
            Console.Read();
        }
    }
}
