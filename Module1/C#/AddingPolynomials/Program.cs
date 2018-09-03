using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolynomials
{
    class Program
    {
        static void SumOfPolynomials(int n, int[] polyOne, int[] polyTwo)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = polyOne[i] + polyTwo[i];

            }
            Console.WriteLine(string.Join(" ",result));
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] polyOne = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] polyTwo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            SumOfPolynomials(n, polyOne, polyTwo);
        }
    }
}
