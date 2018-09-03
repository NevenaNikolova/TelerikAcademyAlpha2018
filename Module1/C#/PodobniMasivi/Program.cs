using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodobniMasivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numsOne = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int m = int.Parse(Console.ReadLine());
            string[] numsTwo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> firstArr = new List<int>();
            for (int i = 0; i < n; i++)
            {
                firstArr.Add(int.Parse(numsOne[i]));
            }

            List<int> secondArr = new List<int>();

            for (int i = 0; i < m; i++)
            {
                secondArr.Add(int.Parse(numsTwo[i]));
            }
            firstArr.Sort();
            secondArr.Sort();


            for (int i = 0; i < firstArr.Count - 1; i++)
            {
                while (i >= 0 && i < firstArr.Count - 1 && firstArr[i] == firstArr[i + 1])
                {
                    firstArr.Remove(firstArr[i]);
                }

            }
            for (int i = 0; i < secondArr.Count - 1; i++)
            {
                while (i >= 0 && i < secondArr.Count - 1 && secondArr[i] == secondArr[i + 1])
                {
                    secondArr.Remove(secondArr[i]);
                }
            }
            int len = Math.Max(firstArr.Count, secondArr.Count);
            bool areEqual = true;

            List<int> result = new List<int>();
            for (int i = 0; i < len; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    result.Add(firstArr[i]);
                    areEqual = false;
                }
                else
                {
                    areEqual = true;
                }
            }
            if (areEqual)
            {
                Console.WriteLine(firstArr.Count);
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}
