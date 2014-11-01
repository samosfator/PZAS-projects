using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysMatrixStrings {
    static class Arrays {
        public static int MaxNumberIndex<T>(IEnumerable<T> array) {
            var arr = array.Cast<double>().ToArray();
            return Array.IndexOf(arr, arr.Max());
        }

        public static double MultiplyInNullRange(double[] array) {
            var result = 1.0;

            var firstNullIndex = Array.IndexOf(array, 0);
            Console.WriteLine("firstNullIndex: {0}", firstNullIndex);

            var secondNullIndex = Array.IndexOf(array, 0, ++firstNullIndex);
            Console.WriteLine("secondNullIndex: {0}", secondNullIndex);

            for (var i = firstNullIndex; i < secondNullIndex; i++) {
                Console.Write(array[i] + " * ");
                result *= array[i];
            }

            Console.WriteLine("\b\b= " + result);

            return result;
        }

        public static double[] Transform(double[] array) {
            var evenElements = array.Where(el => Array.IndexOf(array, el) % 2 == 0);
            var odd = array.Except(evenElements).ToArray();
            var even = evenElements.ToArray();
            var joined = new double[odd.Length + even.Length];
            odd.CopyTo(joined, 0);
            even.CopyTo(joined, odd.Length);
            return joined;
        }
    }
}
