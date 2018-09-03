using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SaddyCooper
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int count = 1;
            BigInteger firstProduct = FindProduct(number);
            BigInteger result = 1;

            if (firstProduct <= 9)
            {
                result = firstProduct;
            }
            else
            {
                while (firstProduct > 9)
                {
                    count++;
                    result = FindProduct(firstProduct);
                    firstProduct = result;
                    if (count == 10)
                    {
                        break;
                    }
                }
            }
            if (count == 10)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(count);
                Console.WriteLine(result);
            }
        }
        static BigInteger FindProduct(BigInteger number)
        {
            BigInteger product = 1;
            while (number > 0)
            {
                number /= 10;
                BigInteger currentSum = SumAtEvenPos(number);
                product *= currentSum;
            }
            return product;
        }
        static BigInteger SumAtEvenPos(BigInteger number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                string num = number.ToString();
                long sum = 0;
                for (int i = 0; i < num.Length; i += 2)
                {
                    sum += num[i] - '0';
                }
                return sum;
            }
        }
    }
}
