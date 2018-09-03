using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long factorial = 1;

            for (int i = n; i >0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
