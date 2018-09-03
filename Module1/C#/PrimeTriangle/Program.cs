using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                bool isPrimeNumber = GetPrime(i);
                if (isPrimeNumber)
                {
                    int row = i;
                    for (int col = 1; col <= row; col++)
                    {
                        if (GetPrime(col))
                        {
                            Console.Write("1");
                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    Console.WriteLine();
                }

            }
        }
        public static bool GetPrime(int number)
        {
            int devider = 2;
            int maxDevider = (int)Math.Sqrt(number);
            bool isPrime = true;
            while (isPrime && (devider <= maxDevider))
            {
                if (number % devider == 0)
                {
                    isPrime = false;
                }
                devider++;
            }
            return isPrime;
        }
    }
}
