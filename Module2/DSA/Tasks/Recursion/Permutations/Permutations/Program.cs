using System;

namespace Permutations
{
    class Program
    {     
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var permutations = new int[n];
            var used = new bool[n];
            PrintPermutations(0,permutations,used);
        }

        private static void PrintPermutations(int index, int[] permutations, bool[] used)
        {
            int n = permutations.Length;
            if (index == n)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            for (int j = 0; j < n; ++j)
            {
                if (used[j])
                {
                    continue;
                }
                permutations[index] = j+1;
                used[j] = true;
                PrintPermutations(index + 1, permutations, used);
                used[j] = false;
            }
        }
    }
}
