using System;

namespace ArraysMatrixStrings {
    static class Program {
        public static void Main() {
            int[][] matrix = {
                                 new[] {21, 24, 3, 0},
                                 new[] {-1, 23, 300, -2},
                                 new[] {32, -2, 122, 122},
                                 new[] {24, 23, -2, 23}
                             };
            //Console.WriteLine(Arrays.MaxNumberIndex(new double[] { 10, -2, -23, 23, 23, -2, 3, -2, 222 }));
            //Console.WriteLine(Arrays.MultiplyInNullRange(new double[] { 10, -2, 0, -23, 23, 23, 0, -2, 3, -2, 222 }));
            //Arrays.Transform(new double[] { 10, -2, 0, -23, 23, 23, 0, -2, 3, -2, 222 }).ToList().ForEach(Console.WriteLine);

            //Console.WriteLine(new Matrix(matrix).FindSameColumnAndRow());
            //Console.WriteLine(new Matrix(matrix).SumRowsWithNegativeElements());

            var strings = new Strings(Console.ReadLine());
            Console.WriteLine("Рядок має {0} чисел", strings.CountNumbers());
            //Console.WriteLine(strings.RemoveNonLatinWords());
            Console.WriteLine(strings.RemoveEvenWords());
            Console.Read();
        }
    }
}
