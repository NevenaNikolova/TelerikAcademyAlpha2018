using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsePath
{
    class HorsePath
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            int[] dRows = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] dCols = { -1, 1, -2, 2, -2, 2, -1, 1 };

            int counter = 1;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(0); c++)
                {                   
                    int row = r;
                    int col = c;

                    while (matrix[row,col]== 0)
                    {
                        matrix[row, col] = counter;
                        counter++;

                        for (int dir = 0; dir < dRows.Length; dir++)
                        {
                            int nextRow = row + dRows[dir];
                            int nextCol = col + dCols[dir];

                            if (nextRow < 0 || nextRow >= matrix.GetLength(0)
                                || nextCol < 0 || nextCol >= matrix.GetLength(1))
                            {
                                continue;
                            }

                            if (matrix[nextRow, nextCol] > 0)
                            {
                                continue;
                            }

                            row = nextRow;
                            col = nextCol;
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
