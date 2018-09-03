using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrookedWalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int sumEven = 0;
            int currentPos = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                while (currentPos > 0 && currentPos < numbers.Length)
                {
                    int max = Math.Max(numbers[currentPos], numbers[currentPos - 1]);
                    int min = Math.Min(numbers[currentPos], numbers[currentPos - 1]);
                    int diff = max - min;
                    if (diff % 2 != 0)
                    {
                        currentPos += 1;
                    }
                    else
                    {
                        sumEven += diff;
                        currentPos += 2;
                    }
                }
            }

            Console.WriteLine(sumEven);
        }
    }
}
