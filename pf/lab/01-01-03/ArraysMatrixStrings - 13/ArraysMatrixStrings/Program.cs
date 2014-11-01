using System;

namespace ArraysMatrixStrings {
    static class Program {
        public static void Main() {
            int[][] inputMatrix = {
                                 new[] {21, 24, 0, 0},
                                 new[] {21, 23, 0, -2},
                                 new[] {32, 23, 0, 122},
                                 new[] {24, -3, 0, 23}
                             };
            var matrix = new Matrix(inputMatrix);
            Arrays.CountNullElements(new double[] { 10, -2, 0, 23, 23, 0, 3, -2, 222 });
            Arrays.MultiplyInRange(new double[] { 10, -2, 0, -23, 23, 23, 0, -2, 3, -2, 222 });
            Arrays.SortByAbs(new double[] { 10, -2, 0, -23, 23, 23, 0, -2, 3, -2, 222 });

            matrix.CountRowsWithNullElement();
            matrix.ColumnWithMostSameEl();

            Console.WriteLine("Введіть строку: ");
            var strings = new Strings(Console.ReadLine());
            Console.WriteLine("Всі символи, які розташовані після першої двокрапки: ");
            strings.SplitAfterColon();
            Console.WriteLine("Кількість речень, що містять непарну кількість слів: ");
            strings.CountSentencesWithOddWords();
            Console.WriteLine("Видалення всіх слів після ком: ");
            strings.RemoveWordsAfterComma();
            Console.Read();
        }
    }
}
