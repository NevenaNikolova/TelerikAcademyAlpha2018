using System;
using System.Linq;

namespace DevisibleBy7And3
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 3, 7, 21, 15, 28, 30, 42 };

            var query = numbers
                .Where(x => x % 7 == 0 && x % 3 == 0);

            Console.WriteLine(string.Join(" ", query.ToArray()));

        }
    }
}
