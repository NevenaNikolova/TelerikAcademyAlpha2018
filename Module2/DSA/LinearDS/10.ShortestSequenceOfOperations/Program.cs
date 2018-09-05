using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ShortestSequenceOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(m);

            int current = m;

            while (current / 2 >= n)
            {
                current /= 2;
                queue.Enqueue(current);
            }
            while (current - 2 >= n)
            {
                current -= 2;
                queue.Enqueue(current);
            }
            while (current - 1 >= n)
            {
                current -= 1;
                queue.Enqueue(current);
            }
            Console.WriteLine(string.Join("->", queue.Reverse()));
        }
    }
}
