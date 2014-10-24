using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysMatrixStrings {
    class Arrays {
        public static double SumPositiveElements<T>(IEnumerable<T> array) {
            var arr = array.Cast<double>().ToArray();
            return arr.Where(i => i > 0).Sum(i => i);
        }

        public static double MultiplyMinMaxRange(double[] array) {
            var result = 1.0;

            var maxAbs = array.Max(e => Math.Abs(e));
            var maxAbsIndex = Array.IndexOf(array, array.Max().Equals(maxAbs) ? maxAbs : -maxAbs);
            Console.WriteLine("maxModIndex: {0}", maxAbsIndex);

            var minAbs = array.Min(e => Math.Abs(e));
            var minAbsIndex = Array.IndexOf(array, array.Min().Equals(minAbs) ? minAbs : -minAbs);
            Console.WriteLine("minModIndex: {0}", minAbsIndex);

            var iterCondition = new[] { minAbsIndex, maxAbsIndex };
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
