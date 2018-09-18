using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OccurencesOfNumbers
{
    class Program
    {
        static void Main()
        {
            double[] arr = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> occurencesDict = new Dictionary<double, int>();

            foreach (var number in arr)
            {
                int count;
                if (!occurencesDict.TryGetValue(number, out count))
                {
                    count = 0;
                }
                occurencesDict[number] = count + 1;
            }

            foreach (var item in occurencesDict)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
