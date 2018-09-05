using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.NumberOfOccurences
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
           
            var occurances = new int[1001];

            foreach (var number in numbers)
            {
                occurances[number]++;
            }

            for (int i = 0; i < occurances.Length; i++)
            {
                if (occurances[i] != 0)
                {
                    Console.WriteLine("{0} -> {1} times", i, occurances[i]);
                }
            }
        }
    }
}
