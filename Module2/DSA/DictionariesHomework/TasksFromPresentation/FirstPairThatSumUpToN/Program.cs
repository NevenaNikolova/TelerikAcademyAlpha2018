using System;
using System.Collections.Generic;

namespace FirstPairThatSumUpToN
{
    class Program
    {
        static void Main()
        {
            HashSet<int> numbers = new HashSet<int> { 12, 2, 6, 14, 8, 1, 5, 3, 12, 5 };
            int n = 13;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Contains(n - i))
                {
                    Console.WriteLine("{"+$"{n-i}, {i}"+"}");
                    break;
                }
            }           
        }
    }
}
