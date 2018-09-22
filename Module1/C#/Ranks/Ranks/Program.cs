using System;
using System.Linq;


namespace Ranks
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var sorted = arr.OrderByDescending(x => x).ToList();
            var result = new int[n];
            int count = 1;

            for (int i = 0; i < sorted.Count; i++)
            {
                var index = Array.IndexOf(arr, sorted[i]);
                result[index] = count;
                count++;
            }
           
            //1 7 3 9
            //Console.WriteLine(string.Join(" ", arr));
            //9 7 3 1
            //Console.WriteLine(string.Join(" ",sorted));

            Console.WriteLine(string.Join(" ",result ));
        }
    }
}
