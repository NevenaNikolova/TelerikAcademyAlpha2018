using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();


            bool[] isVisited = new bool[n];
            StringBuilder result = new StringBuilder();
            int currentIndex = 0;
            int loopStart = -1;

            while (true)
            {
                if (currentIndex < 0 || currentIndex >= n)
                {
                    break;
                }
                if (isVisited[currentIndex])
                {
                    loopStart = currentIndex;
                    break;
                }
                result.Append(currentIndex);
                result.Append(' ');
                isVisited[currentIndex] = true;
                currentIndex = numbers[currentIndex];
            }

            if (loopStart >= 0)
            {
                int index = result.ToString().IndexOf((" " + loopStart + " ").ToString());

                if (index < 0)
                {
                    result.Insert(0, '(');
                }
                else
                {
                    result[index] = '(';
                }
                result[result.Length - 1] = ')';
            }
            Console.WriteLine(result.ToString().Trim());


        }
    }
}

