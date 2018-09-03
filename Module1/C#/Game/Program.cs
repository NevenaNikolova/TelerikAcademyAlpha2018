using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int units = n % 10;
            int tens = (n / 10) % 10;
            int hundreds = (n / 100) % 10;

            int maxNum = int.MinValue;
            int multiplyied = units * tens * hundreds;
            maxNum = Math.Max(maxNum, multiplyied);

            int summed = units + tens + hundreds;
            maxNum = Math.Max(maxNum, summed);

            int mixed = units * tens + hundreds;
            maxNum = Math.Max(maxNum, mixed);

            int mixed2 = tens * hundreds + units;
            maxNum = Math.Max(maxNum, mixed2);          

            Console.WriteLine(maxNum);



        }
    }
}
