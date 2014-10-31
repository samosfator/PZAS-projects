using System;

namespace ArraysMatrixStrings {
    static class Program {
        public static void Main() {
            int[][] testMatrix = {
                                 new[] {21, 24, 3, 0},
                                 new[] {-1, 23, 0, 11},
                                 new[] {-20, 90, 21, 2}
                             };
            var matrix = new Matrix(testMatrix);
            matrix.Sort();
            matrix.GetNotNullColumns();

            var testArray = new double[] { 10, -2, -23, 23, 23, -2, 3, -2, 222 };
            Arrays.SumPositiveElements(testArray);
            Arrays.MultiplyMinMaxRange(testArray);
            Arrays.SortDesc(testArray);

            var strings = new Strings(Console.ReadLine());
            strings.IsParenthesesConcur();
            strings.PrintLongestWord();
            strings.RemoveLatinWords();
            Console.Read();
        }
    }
}
