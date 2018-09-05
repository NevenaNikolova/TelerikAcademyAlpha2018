using System;
using System.Linq;

namespace _08.MajorantOfAnArray
{
    class Program
    {
        //Input: 2, 2, 3, 3, 2, 3, 4, 3, 3
        static void Main()
        {
            int[]array = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int size = array.Length;
            int condition = size / 2 + 1;
            bool isMajorant = false;

            for (int i = 0; i < array.Length; i++)
            {
                int count = array.Where(x => x == array[i]).Count();
                if (count >= condition)
                {
                    Console.WriteLine(array[i]);
                    isMajorant = true;
                    break;
                }               
            }
            if (!isMajorant)
            {
                Console.WriteLine("No majorant of this array!");
            }
        }
    }
}
