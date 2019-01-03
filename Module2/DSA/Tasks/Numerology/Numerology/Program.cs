using System;
using System.Collections.Generic;
using System.Linq;

namespace Numerology
{
    class Program
    {
        public static int[] Count=new int[10];
        public static void Main()
        {          
            var digits=Console.ReadLine()
                .Select(x => x - '0')
                .ToList();
            
            Divine(digits);
            Console.WriteLine(string.Join(" ", Count));

        }

        public static void Divine(List<int> digits)
        {
            if (digits.Count == 1)
            {
                ++ Count[digits[0]];
                return;
            }
            for (int i = 1; i < digits.Count; i++)
            {
                var a = digits[i - 1];
                var b = digits[i];
                digits.RemoveAt(i);
                digits[i - 1] = Calculate(a, b);               
                Divine(digits);
                digits[i - 1] = a;
                digits.Insert(i, b);
            }
        }

        public static int Calculate(int a, int b)
        {
            return (a + b) * (a ^ b) % 10;
        }
    }
}
