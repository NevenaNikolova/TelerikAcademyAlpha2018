using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraySearch
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            HashSet<int> inputNums = new HashSet<int>(input);
            HashSet<int> arr = Enumerable.Range(1, input.Length)
                .ToHashSet();
            arr.ExceptWith(inputNums);

            Console.WriteLine(string.Join(",", arr));
        }
    }
}
