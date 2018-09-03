using System;
using System.Numerics;

namespace SecretsOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            BigInteger specialSum = FindSpecSum(n);
            int lengthOfSequence = (int)specialSum % 10;
            if (lengthOfSequence == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", specialSum);
            }

            string result = string.Empty;
            int r = (int)specialSum % 26;

            for (int i = 0; i < lengthOfSequence; i++)
            {
                Console.Write((char)('A'+(r+i)%26));
            }
            Console.WriteLine();
        }

        static BigInteger FindSpecSum(string number)
        {
            BigInteger result = 0;
            int position = 1; 
            for (int i = number.Length - 1; i >= 0; i -= 2, position += 2)
            {
                if (!char.IsDigit(number[i]))
                {
                    continue;
                }
                int currentSum = (number[i] - '0') * (int)Math.Pow(position, 2);
                result += currentSum;
            }
            position = 2;
            for (int i = number.Length - 2; i >= 0; i -= 2, position += 2)
            {
                if (!char.IsDigit(number[i]))
                {
                    continue;
                }
                int currentSum = (int)Math.Pow((number[i] - '0'), 2) * position;
                result += currentSum;
            }

            return result;
        }
    }
}
