using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysMatrixStrings {
    static class Arrays {
        public static double SumNegativeElements<T>(IEnumerable<T> array) {
            var arr = array.Cast<double>().ToArray();
            return arr.Where(i => i < 0).Sum(i => i);
        }

        public static double MultiplyMinMaxRange(double[] array) {
            var result = 1.0;

            var maxIndex = Array.IndexOf(array, array.Max());
            Console.WriteLine("maxIndex: {0}", maxIndex);

            var minIndex = Array.IndexOf(array, array.Min());
            Console.WriteLine("minIndex: {0}", minIndex);

            var iterCondition = new[] { minIndex, maxIndex };
            Array.Sort(iterCondition);
            for (var i = iterCondition[0]; i < iterCondition[1]; i++) {
                Console.Write(array[i] + " * ");
                result *= array[i];
            }

            Console.WriteLine("\b\b= " + result);

            return result;
        }
    }
}
