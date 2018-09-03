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
            int sum = 0;

            for (int i = 0; i <= n; i += 7)
            {
                for (int j = i; j <= n; j += 5)
                {
                    if ((n - j) % 2 == 0)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}


