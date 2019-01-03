using System;

namespace _03.SkipDuplicates
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int index = 0;
            int start = 1;
            int end = n;
            int[] arr = new int[k];

            PrintCombinationsWithoutDuplicates(arr, index, start, end);

        }

        private static void PrintCombinationsWithoutDuplicates(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine("(" + string.Join(" ", arr) + ")");
                return;
            }
            else
            {
                for (int i = start; i <= end; i++)
                {                 
                        arr[index] = i;
 
                    PrintCombinationsWithoutDuplicates(arr, index + 1, i+1, end);
                }
            }
        }
    }
}
