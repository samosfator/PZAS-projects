using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMatrixStrings {
    class Arrays {
        public static double PositiveAverage(double[] array) {
            double sum = 0;
            //TODO Google for C# streams
            foreach (double a in array) {
                if (a > 0) sum += a;
            }
            return sum;
        }

        //TODO To complete
        public static double MinMaxRangeMupltiply(double[] array) {
            double minMod, maxMod, result;
            minMod = maxMod = result = 0;
            
            minMod = array.Min(e => Math.Abs(e));
            maxMod = array.Max(e => Math.Abs(e));
            
            Console.WriteLine("minMod: " + minMod);
            Console.WriteLine("maxMod: " + maxMod);

            return result;
        }
    }
}
