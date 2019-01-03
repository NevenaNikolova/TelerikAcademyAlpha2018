using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace Medians
{
    class Program
    {
        static OrderedBag<int> numbers = new OrderedBag<int>();
        static List<double> result = new List<double>();

        static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != "EXIT")
            {
                var args = line.Split();
                var command = args[0];

                switch (command)
                {
                    case "ADD":
                        AddNumber(int.Parse(args[1]));
                        break;
                    case "FIND":
                        FindMedian();
                        break;
                }
            }
            Console.WriteLine(string.Join("\n", result));
        }
        public static void FindMedian()
        {
            int count = numbers.Count;
            double median = 0;
            if (count % 2 == 0)
            {
                var firstMed = numbers[count / 2];
                var secondMed = numbers[count / 2 - 1];
                median = (double)(firstMed + secondMed) / 2;
            }
            else
            {
                median = numbers.AsList()[(count - 1) / 2];
            }
            result.Add(median);
        }
        private static void AddNumber(int num)
        {
            numbers.Add(num);
        }
    }
}
