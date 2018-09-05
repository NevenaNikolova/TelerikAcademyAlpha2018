using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LongestSubsequenceOfEqualNumbers
{
    class Program
    {
        //test input: 4 2 2 5 2 3 3 3  
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            int bestNum = 0;
            int currentSequence = 1;
            int bestSequence = 1;

            for (int i = 0; i <numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentSequence++;
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestNum = numbers[i];
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }
            List<int> result = new List<int>(bestSequence);

            if (bestSequence > 1)
            {
                for (int i = 0; i < bestSequence; i++)
                {
                    result.Add(bestNum);
                }
            }
            else
            {
                Console.WriteLine(bestNum);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
