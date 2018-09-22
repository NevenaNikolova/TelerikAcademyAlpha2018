using System;
using System.Numerics;

namespace Calculate3_
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var nToKFact = CalculateFactorial(n, k);
            var nMinusKFact = CalculateFactorial(n - k, 1);

            var result = nToKFact/nMinusKFact;

            Console.WriteLine(result);
        }

        private static BigInteger CalculateFactorial(int startNum, int endNum)
        {
            BigInteger result = 1;
            for (int i = startNum; i >endNum; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
