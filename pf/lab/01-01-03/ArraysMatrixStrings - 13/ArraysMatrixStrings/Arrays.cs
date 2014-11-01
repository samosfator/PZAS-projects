using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysMatrixStrings {
    static class Arrays {
        public static void CountNullElements(IEnumerable<double> array) {
            Console.WriteLine(array.Count(el => el.Equals(0)));
        }

        public static void MultiplyInRange(double[] array) {
            var result = 0.0;

            Console.WriteLine("Введiть початок дiапазону: ");
            var firstRangeVal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть кiнець дiапазону: ");
            var secondRangeVal = Convert.ToDouble(Console.ReadLine());

            foreach (var i in array) {
                if (i >= firstRangeVal && i <= secondRangeVal) {
                    Console.Write(i + " + ");
                    result += i;
                }
            }

            Console.WriteLine("\b\b= " + result);
        }

        public static void SortByAbs(double[] array) {
            Array.Sort(array, (d, d1) => Math.Abs(d).CompareTo(Math.Abs(d1)));
            Console.Write("[");
            array.ToList().ForEach(el => Console.Write(el + ", "));
            Console.WriteLine("\b\b]");
        }
    }
}
