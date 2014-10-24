using System;

//2nd variant
namespace ArraysMatrixStrings {
    static class Program {
        public static void Main() {
            int[][] matrix = {
                                 new[] {21, 24, 3, 0},
                                 new[] {-1, 23, 300, -2},
                                 new[] {32, -2, 122, 122}
                             };
            //Console.WriteLine(new Matrix(matrix).CountMaxOccurences());
            //Console.WriteLine(new Matrix(matrix).GetNotNullRows());

            //Console.WriteLine(Arrays.SumNegativeElements(new double[] { 10, -2, -23, 23, 23, -2, 3, -2, 222 }));
            //Console.WriteLine(Arrays.MultiplyMinMaxRange(new double[] { 10, -2, -23, 23, 23, -2, 3, -2, 222 }));

            var strings = new Strings(Console.ReadLine());
            //Console.WriteLine(strings.CountOddLengthWords());
            strings.PrintLetterOccurrences();
            //strings.RemoveWordsInParentheses();
            Console.Read();
        }
    }
}
