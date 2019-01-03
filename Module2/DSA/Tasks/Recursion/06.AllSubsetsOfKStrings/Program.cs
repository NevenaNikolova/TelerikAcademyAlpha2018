using System;

namespace _06.AllSubsetsOfKStrings
{
    class Program
    {
        static void Main()
        {
            string[] set = Console.ReadLine().Trim('{', '}').Split(", ");
            int k = int.Parse(Console.ReadLine());
            int index = 0;
            int start = 0;
            string[] subsets = new string[k];

            PrintSubsets(set,index,start,subsets);

        }

        private static void PrintSubsets(string[] set, int index,int start, string[]subsets)
        {
            if (index >= subsets.Length)
            {
                Console.WriteLine("(" + string.Join(" ", subsets) + ")");
                return;
            }
            else
            {
                for (int i = start; i < set.Length; i++)
                {
                    subsets[index] = set[i];
                    PrintSubsets(set, index + 1, i+1, subsets);
                }
            }
        }
    }
}
