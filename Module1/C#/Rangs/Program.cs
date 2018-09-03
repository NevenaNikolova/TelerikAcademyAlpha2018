using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testT
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[n];
            int[] numbersToSort = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(input[i]);
                numbersToSort[i] = numbers[i];
            }
            Array.Sort(numbersToSort);
            Array.Reverse(numbersToSort);

            for (int i = 0; i < numbers.Length; i++)
            {
                int index = 0;
                for (int j = 0; j < numbersToSort.Length; j++)
                {
                    if (numbersToSort[j] == numbers[i])
                    {
                        index = j;
                        break;
                    }
                }
                numbers[i] = index + 1;
            }


            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
