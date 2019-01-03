using System;

namespace _07.FindAllPathsInMatrix
{
    class Program
    {

        private static char[,] matrix;
        static void Main()
        {
            matrix = new char[100,100];
            matrix[99, 99] = 'e';
            CheckIfPathExists(0, 0);
        }

        private static void CheckIfPathExists(int row, int col)
        {
            if (row < 0 || col < 0
                || row >= matrix.GetLength(0)
                || col >= matrix.GetLength(1))
            {
                return;
            }
            if (matrix[row, col] == 'e')
            {
                Console.WriteLine("A path was found!");
                //return;                
                Environment.Exit(0);
            }
            if (matrix[row, col] =='V')
            {
                return;
            }

            matrix[row, col] = 'V';

            CheckIfPathExists(row + 1, col);
            CheckIfPathExists(row - 1, col);
            CheckIfPathExists(row, col + 1);
            CheckIfPathExists(row, col - 1);

        }
    }
}
