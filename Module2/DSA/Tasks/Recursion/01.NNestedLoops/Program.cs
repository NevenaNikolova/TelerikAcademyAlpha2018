using System;

namespace _01.NNestedLoops
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void Main(string[] args)
        {
            //number of Loops
            int n = int.Parse(Console.ReadLine());
            numberOfLoops = n;

            //number of Iterations
            numberOfIterations = n;

            loops = new int[numberOfLoops];

            NestedLoops(0);          
        }

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int i = 1; i <=numberOfIterations; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }

        }

        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
