using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ExtractStringsWithOddOccurences
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> occurences = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(", ");

            foreach (var str in input)
            {
                int count;
                if (!occurences.TryGetValue(str, out count))
                {
                    count = 0;
                }
                occurences[str] = count + 1;
            }

            var result = occurences
                .Where(x => x.Value % 2 == 1)
                .Select(x=>x.Key)
                .ToList();
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
