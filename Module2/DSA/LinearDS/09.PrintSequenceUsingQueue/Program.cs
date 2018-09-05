using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PrintSequenceUsingQueue
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            int steps = 50;

            for (int i = 0; i < steps; i++)
            {
                int current = queue.First();
                queue.Enqueue(current + 1);
                queue.Enqueue(current * 2 + 1);
                queue.Enqueue(current + 2);

                Console.Write(queue.Dequeue());

                if (i != steps - 1)
                {
                    Console.Write(", ");
                }
            }

        }
    }
}
