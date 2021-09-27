using System;
using System.Collections.Generic;
using System.Text;

namespace ColorCount {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine(CountColors(3, new List<int> { 1, 2 }));
            Console.WriteLine(CountColors(4, new List<int> { 2, 2 }));
        }

        public static int CountColors(int n, IList<int> colors) {
            List<int> resultList = new List<int>();
            foreach (int color in colors) {
                for (int i = 0; i < color; i++) {
                    resultList.Add(i + 1);
                }
            }
            //Console.WriteLine(ArrayToString(resultList));
            return CountHelper(resultList, 0, n - 1);
        }

        private static int CountHelper(List<int> list, int k, int n) {
            if (k == n) {
                //Console.Write(ArrayToString(list));
                //Console.WriteLine(" : {0} ", CheckCondition(list));
                return CheckCondition(list) ? 1 : 0;
            } else {
                int count = 0;
                for(int i = k; i <= n; i++) {
                    if (CheckSwap(list, k, i)) {
                        Swap(k, i, list);
                        count += CountHelper(list, k + 1, n);
                        Swap(k, i, list);
                    }
                }
                return count;
            }
        }

        private static bool CheckCondition(List<int> result) {
            for(int i = 0; i < result.Count; i++) {
                if (i != result.LastIndexOf(result[i])) continue;

                int lastNext = result.LastIndexOf(result[i] + 1);
                if (lastNext != -1 && i > lastNext) return false;
            }
            return true;
        }

        private static bool CheckSwap(IList<int> list, int start, int current) {
            for(int i = start; i < current; i++) {
                if (list[i] == list[current]) return false;
            }
            return true;
        }

        private static void Swap(int a, int b, IList<int> list) {
            if (a == b) return;

            var temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        private static string ArrayToString(IList<int> list) {
            StringBuilder builder = new();
            builder.Append("[ ");
            foreach(int i in list) {
                builder.Append($"{i} ");
            }
            builder.Append("]");
            return builder.ToString();
        }
    }
}
