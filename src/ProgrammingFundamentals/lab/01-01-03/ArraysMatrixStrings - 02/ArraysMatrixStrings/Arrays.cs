using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysMatrixStrings {
    static class Arrays {
        public static void SumPositiveElements<T>(IEnumerable<T> array) {
            var arr = array.Cast<double>().ToArray();
            var sum = arr.Where(i => i > 0).Sum(i => i);
            Console.WriteLine("Сума додатнiх елементiв масиву: {0} \n", sum);
        }

        public static void MultiplyMinMaxRange(double[] array) {
            Console.WriteLine("Добуток елементiв масиву, що розташованi мiж максимальним " +
                              "за модулем i мiнiмальним за модулем елементами: ");

            var result = 1.0;

            var maxAbs = array.Max(e => Math.Abs(e));
            var maxAbsIndex = Array.IndexOf(array, array.Max().Equals(maxAbs) ? maxAbs : -maxAbs);

            var minAbs = array.Min(e => Math.Abs(e));
            var minAbsIndex = Array.IndexOf(array, array.Min().Equals(minAbs) ? minAbs : -minAbs);

            var iterCondition = new[] { minAbsIndex, maxAbsIndex };
            Array.Sort(iterCondition);
            for (var i = iterCondition[0] + 1; i < iterCondition[1]; i++) {
                Console.Write(array[i] + " * ");
                result *= array[i];
            }

            Console.WriteLine("\b\b= {0} \n", result);
        }

        public static void SortDesc(double[] array) {
            Console.WriteLine("Впорядкувати елементи масиву за спаданням: ");
            Array.Sort(array);
            PrintArray(array.Reverse());
        }

        private static void PrintArray(IEnumerable<double> array) {
            Console.Write("[");
            array.ToList().ForEach(el => Console.Write(el + ", "));
            Console.WriteLine("\b\b]\n");
        }
    }
}
