using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.RemoveNumbersThatOccurOddTimes
{
    class Program
    {
        static void Main()
        {            
            // input: 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2

            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
           
            List<int> result = new List<int>(numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                int count = numbers.FindAll(x => x == numbers[i]).Count();
                if (count % 2 == 0)
                {
                    result.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(", ", result));
            

        }
    }
}
