using System;

namespace _09.FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("0");
                return;
            }
            if (n > 1 && n <= 50)

            {
                long a = 0;
                long b = 1;
                long c;
                Console.Write("{0}, {1}", a, b);

                for (int i = 2; i < n; i++)
                {
                    c = a + b;
                    Console.Write(", {0}", c);
                    a = b;
                    b = c;
                }
            }
        }
    }
}

