using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNumbers
{
    class Program
    {
        public static bool GetBalancedNumber(int number)
        {
            bool isBalanced = false;
            int units = number % 10;
            int tens = (number / 10) % 10;
            int hundreds = (number / 100) % 10;
            if (tens == (units + hundreds))
            {
                isBalanced = true;
            }
            return isBalanced;
        }
        static void Main()
        {
            int sum = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (GetBalancedNumber(number))
                {
                    sum += number;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
