using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int counter = 1;
            int size = n * n;
            int depth = 0;

            while (counter <= size)
            {
                //right
                for (int c = depth; c <= n - 1 - depth; c++)
                {
                    matrix[depth, c] = counter;
                    counter++;
                }
                //down
                for (int r = 1 + depth; r <= n-1- depth; r++)
                {
                    matrix[r, n - 1 - depth] = counter;
                    counter++;
                }
                //left
                for (int c = n - 2 - depth; c >= depth; c--)
                {
                    matrix[n - 1 - depth, c] = counter;
                    counter++;
                }
                //up
                for (int r = n - 2 - depth; r > depth; r--)
                {
                    matrix[r, depth] = counter;
                    counter++;
                }

                depth++;
            }


            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,3}", matrix[r, c]);
                }
                Console.WriteLine();
            }

        }
    }
}
