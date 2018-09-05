using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Labyrinth
    {
        static string[,] lab =
            {
                { "0", "0", "0", "X", "0", "X" },
                { "0", "X", "0", "X", "0", "X" },
                { "0", "*", "X", "0", "X", "0" },
                { "0", "X", "0", "0", "0", "0" },
                { "0", "0", "0", "X", "X", "0" },
                { "0", "0", "0", "X", "0", "X" }
            };
        static readonly int rows = lab.GetLength(0);
        static readonly int cols = lab.GetLength(1);
        static int counter = 0;

        static void Main(string[] args)
        {
            int row = 2;
            int col = 1;
            FindPaths(row, col);
            lab[row, col] = "*";
            PrintPaths(lab);
        }

        static void PrintPaths(string[,] lab)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (lab[i, j] == "0")
                    {
                        lab[i, j] = "u";
                    }
                    Console.Write("{0,4}", lab[i, j]);
                }
                Console.WriteLine();
            }

        }

        static void FindPaths(int row, int col)
        {
            //right
            if (IsPossibleMove(row, col + 1))
            {
                counter++;
                lab[row, col + 1] = counter.ToString();

                FindPaths(row, col + 1);
                counter--;
            }
            //down
            if (IsPossibleMove(row + 1, col))
            {
                counter++;
                lab[row + 1, col] = counter.ToString();

                FindPaths(row + 1, col);
                counter--;
            }
            //up
            if (IsPossibleMove(row - 1, col))
            {
                counter++;
                lab[row - 1, col] = counter.ToString();

                FindPaths(row - 1, col);
                counter--;
            }
            //left
            if (IsPossibleMove(row, col - 1))
            {
                counter++;
                lab[row, col - 1] = counter.ToString();

                FindPaths(row, col - 1);
                counter--;
            }
        }
        static bool IsPossibleMove(int row, int col)
        {
            if (row < 0 || row >= rows
                || col < 0 || col >= cols)
            {
                return false;
            }
            else if (lab[row, col] == "X" || lab[row, col] != "0")
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}


