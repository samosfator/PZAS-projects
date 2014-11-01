using System;
using System.Linq;

namespace ArraysMatrixStrings {
    static class Program {
        public static void Main() {
            int[][] matrix = {
                                 new[] {-21, 24, -3, 0},
                                 new[] {-1, 23, 300, -2},
                                 new[] {32, -2, 122, 0},
                                 new[] {24, 23, -2, 23}
                             };
            //Console.WriteLine(Arrays.CountGreaterNumbers(new double[] { 10, -2, -23, 23, 23, -2, 3, -2, 222 }, 12));
            //Console.WriteLine(Arrays.ProductAfterMin(new double[] { 10, -2, 0, -23, 23, 23, 0, -2, -300, -2, -2222 }));
            //Arrays.Sort(new double[] { 10, -2, 0, -23, 23, 23, 0, -2, 3, -2, 222 }).ToList().ForEach(Console.WriteLine);

            //Console.WriteLine(new Matrix(matrix).FindNegativeElements());
            //Console.WriteLine(new Matrix(matrix).AbsSumAfterFirstPositive());

            var strings = new Strings(Console.ReadLine());
            //strings.CountWordsInSentences();
            //strings.PrintLongestSentence();
            strings.RemoveWordsWithPrelastVowel();
            Console.Read();
        }
    }
}
