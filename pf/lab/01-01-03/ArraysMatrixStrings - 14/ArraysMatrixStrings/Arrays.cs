using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysMatrixStrings {
    static class Arrays {
        public static int CountGreaterNumbers(IEnumerable<double> array, double c) {
            return array.Count(el => el > c);
        }

        public static double ProductAfterMin(double[] array) {
            double result = 1;
            var minIndex = Array.IndexOf(array, array.Min());
            for (var i = ++minIndex; i < array.Length; i++) {
                result *= array[i];
            }
            if (minIndex.Equals(array.Length)) result = 0;
            return result;
        }

        public static IEnumerable<double> Sort(double[] array) {
            Array.Sort(array, (d1, d2) => Math.Abs(d1).CompareTo(Math.Abs(d2)));
            return array;
        }
    }
}
