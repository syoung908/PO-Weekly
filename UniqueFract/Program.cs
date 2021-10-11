using System;
using System.Collections.Generic;

namespace UniqueFract {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine(UniqueFract());
        }

        public static double UniqueFract() {
            double sum = 0.0;
            HashSet<double> fractions = new HashSet<double>();
            for (int i = 1; i < 10; i++) {
                for (int j = 1; j < 10; j++) {
                    double fract = (double) i / j;
                    if (fract < 1 && !fractions.Contains(fract)) {
                        sum += fract;
                        fractions.Add(fract);
                    }
                }
            }

            return sum;
        }
    }
}
