using System;

using System.Text;
using System.Numerics;

namespace BunniesFactory
{
    class Program
    {
        static void Main()
        {
            StringBuilder cages = new StringBuilder();
            string input = " ";

            while (input != "END")
            {
                input = Console.ReadLine();
                cages.Append(input);
            }
            //Console.WriteLine(cages.ToString());
            cages.Remove(cages.Length - 3, 3);
            int cycle = 1;
            int currentSum = 0;
            int nextSum = 0;
            BigInteger product = 1;
            string currentRes = " ";

            for (int i = 0; i < cages.Length; i++)
            {
                for (int j = 0; j < cycle; j++)
                {
                    currentSum += cages[j] - '0';
                }
                if (currentSum > cages.Length)
                {
                    break;
                }
                cages.Remove(0, cycle);

                for (int cag = 0; cag < currentSum; cag++)
                {
                    nextSum += cages[cag] - '0';
                    product *= cages[cag] - '0';
                }
                currentRes = nextSum.ToString().Trim('0', '1') + product.ToString().Trim('0', '1');
                cages.Remove(0, currentSum);
                cages.Insert(0, currentRes);

                currentSum = 0;
                nextSum = 0;
                product = 1;
                currentRes = " ";
                cycle++;
            }

            Console.WriteLine(String.Join(" ", cages.ToString().ToCharArray()));
        }
    }
}
