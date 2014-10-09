using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMatrixStrings {
    class Arrays {
        public static double PositiveAverage<T>(IList<T> array) {
            return array.Where(i => double.Parse(i.ToString()) > 0).Sum(i => double.Parse(i.ToString()));
        }

        public static double MinMaxRangeMupltiply(double[] array) {
            double minMod, maxMod, result;
            int minModIndex, maxModIndex;
            bool AbsPerformed = false;
            minMod = maxMod = result = 0;

            //Get maximum absolute value from the array
            for (int i = 0; i < array.Length; i++) {
                if (Math.Abs(array[i]) > maxMod) {
                    AbsPerformed = array[i] < 0;
                    maxMod = Math.Abs(array[i]);
                }
            }
            maxModIndex = AbsPerformed ? Array.IndexOf(array, -maxMod) : Array.IndexOf(array, maxMod);

            minMod = maxMod;
            //Get minimum absolute value from the array
            for (int i = 0; i < array.Length; i++) {
                if (Math.Abs(array[i]) < minMod) {
                    AbsPerformed = array[i] < 0;
                    minMod = Math.Abs(array[i]);
                }
            }
            minModIndex = AbsPerformed ? Array.IndexOf(array, -minMod) : Array.IndexOf(array, minMod);

            Console.WriteLine("maxMod: {0}, maxModIndex: {1}", maxMod, maxModIndex);
            Console.WriteLine("minMod: {0}, minModIndex: {1}", minMod, minModIndex);

            if (minModIndex < maxModIndex) {
                for (; minModIndex < maxModIndex; minModIndex++) {
                    Console.Write(array[minModIndex] + " + ");
                    result += array[minModIndex];
                }
            } else {
                for (; maxModIndex < minModIndex; maxModIndex++) {
                    Console.Write(array[minModIndex] + " + ");
                    result += array[maxModIndex];
                }
            }

            Console.WriteLine("\b\b= " + result);

            return result;
        }
    }
}
