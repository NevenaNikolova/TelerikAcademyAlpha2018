using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n - 1;

            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("{0,2}",c);
                }
                Console.WriteLine();
            }

            for (int r = n-1; r >=1; r--)
            {
                for (int c = 1; c <= r ; c++)
                {
                    Console.Write("{0,2}", c);
                }
                Console.WriteLine();
            }        
        }
    }
}
