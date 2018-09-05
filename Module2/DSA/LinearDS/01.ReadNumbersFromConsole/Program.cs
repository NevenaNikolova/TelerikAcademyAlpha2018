using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReadNumbersFromConsole
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            string input = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(input))
            {
                int numToAdd = int.Parse(input);
                numbers.Add(numToAdd);
                input = Console.ReadLine();
            }

            int sum = numbers.Sum();
            double average = numbers.Average();
            Console.WriteLine(sum);
            Console.WriteLine(average);            
        }
    }
}
