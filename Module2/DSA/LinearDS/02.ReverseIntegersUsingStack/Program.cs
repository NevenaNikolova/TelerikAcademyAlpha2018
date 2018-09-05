using System;
using System.Collections.Generic;

namespace _02.ReverseIntegersUsingStack
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>(n);

            for (int i = 0; i <n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                numbers.Push(current);
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
