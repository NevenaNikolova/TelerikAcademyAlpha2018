using System;
using System.Linq;

namespace LongestSequenceOfEquals
{
    class LongestSequenceOfEquals
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Enumerable.Range(0, n)
                .Select(x => int.Parse(Console.ReadLine()))
                .ToArray();

            int currentSequence = 1;
            int maxSequence = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentSequence++;
                    maxSequence = Math.Max(currentSequence, maxSequence);
                }
                else
                {
                    currentSequence = 1;
                }             
            }

            Console.WriteLine(maxSequence);
        }
    }
}
