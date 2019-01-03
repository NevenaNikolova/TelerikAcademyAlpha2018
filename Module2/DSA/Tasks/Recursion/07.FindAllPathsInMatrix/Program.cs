using System;

namespace _07.FindAllPathsInMatrix
{
    class Program
    {
        private static char[,] matrix =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };
        static void Main()
        {        
            FindAllPaths(0,0);
        }

        private static void FindAllPaths(int row, int col)
        {
            if (row < 0 || col < 0
                || row >= matrix.GetLength(0)
                || col >= matrix.GetLength(1))
            {
                return;
            }
            if (matrix[row, col] == 'e')
            {
                Console.WriteLine("New path was found!");
                return;
            }
            if (matrix[row, col] != ' ')
            {
                return;
            }
            matrix[row, col] = 's';

            FindAllPaths(row + 1, col);
            FindAllPaths(row - 1, col);
            FindAllPaths(row, col + 1);
            FindAllPaths(row, col - 1);

            matrix[row, col] = ' ';
        }
    }
}
