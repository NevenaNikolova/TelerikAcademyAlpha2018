using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStud = int.Parse(Console.ReadLine());
            int sheetsPerStud = int.Parse(Console.ReadLine());
            double sheetsInBox = 500.0;
            double priceOfBox = double.Parse(Console.ReadLine());

            int totalSheets = numOfStud * sheetsPerStud;
            double reams = totalSheets / sheetsInBox;
            double totalPrice = reams * priceOfBox;

            Console.WriteLine("{0:F2}", totalPrice);

        }
    }
}
