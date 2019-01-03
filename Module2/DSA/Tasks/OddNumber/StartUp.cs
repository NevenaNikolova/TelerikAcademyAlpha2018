using System;
using System.Collections.Generic;

namespace OddNumber
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<long, int> numberOccurenceMap = new Dictionary<long, int>();

            for (int i = 0; i < n; i++)
            {
                long current = long.Parse(Console.ReadLine());
                int count;
                if (!numberOccurenceMap.TryGetValue(current, out count))
                {
                    count = 0;
                }
                numberOccurenceMap[current] = count + 1;
            }

            var result = numberOccurenceMap.FirstOrDefault(x => x.Value % 2 == 1).Key;
            Console.WriteLine(result);
        }
    }
}

