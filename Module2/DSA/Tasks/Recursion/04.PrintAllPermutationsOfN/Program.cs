using System;

namespace _04.PrintAllPermutationsOfN
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            Perm(arr, 0);
        }
        private static void Perm(int[]arr, int start)
        {
            if (start >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            else
            {
                for (int i = start; i < arr.Length; i++)
                {
                    Swap(arr, start, i);
                    Perm(arr, start+1);
                    Swap(arr, start, i);
                }             
            }
        }
        private static void Swap(int[]arr, int first, int second)
        {
            int temp = arr[second];
            arr[second] = arr[first];
            arr[first] = temp;

        }
    }
}
