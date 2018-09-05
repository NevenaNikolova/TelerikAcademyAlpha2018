using System;
using System.Collections.Generic;

namespace _03.WriteAndSortIntegers
{
    class Program
    {
        static void Main()
        {
            var numbers = new SortedSet<int>();

            string input = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(input))
            {
                int current = Convert.ToInt32(input);
                numbers.Add(current);
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
