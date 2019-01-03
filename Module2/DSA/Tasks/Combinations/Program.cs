using System;

namespace Combinations
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] arr = new int[k];
            int index = 0;
            int start = 1;
            PrintCombinations(arr, index, start, n);
            
        }

        private static void PrintCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            for (int i = start; i <=end; i++)
            {
                arr[index] = i;
                PrintCombinations(arr, index + 1, i+1, end);
            }
        }
    }
}
