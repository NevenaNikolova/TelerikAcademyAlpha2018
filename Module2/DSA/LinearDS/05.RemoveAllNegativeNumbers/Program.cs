using System;
using System.Collections.Generic;

namespace _05.RemoveAllNegativeNumbers
{
    class Program
    {
        //input: 1 2 -3 -5 9 10
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<int> result = new List<int>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                int current = int.Parse(input[i]);
                if (current >= 0)
                {
                    result.Add(current);
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
