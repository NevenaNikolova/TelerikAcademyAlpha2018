using System;

namespace _02.CombinationsWithDuplicatesOfK
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];

            CombineWithKDuplicates(arr, 0, 1, n);

        }

        static void CombineWithKDuplicates(int[] arr, int index, int startNum, int endNum)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine("("+string.Join(" ", arr)+")");
                return;
            }
            else
            {
                for (int i = startNum; i <=endNum; i++)
                {
                    arr[index] = i;
                    CombineWithKDuplicates(arr, index + 1, i, endNum);
                }
            }
        }
    }
}
