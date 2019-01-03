using System;

namespace _05.PrintAllOrderedKElementSubsets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            string[] set = Console.ReadLine().Trim('{', '}').Split(", ");            
            string[] variations = new string[k];
            int index = 0;

            PrintVariations(index, set, variations);
        }

        private static void PrintVariations(int index, string[] set, string[] variations)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine("(" + string.Join(" ", variations)+")");
                return;
            }
            else
            {
                for (int i = 0; i < set.Length; i++)
                {
                    variations[index] = set[i];
                    PrintVariations(index + 1, set, variations);
                }
            }
        }
    }
}
