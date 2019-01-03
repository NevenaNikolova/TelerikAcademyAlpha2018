using System;

namespace Portals
{
    class Program
    {
        static int[,] lab;
        static int maxPower = 0;
        static void Main()
        {
            string[] inputPos = Console.ReadLine().Trim().Split();
            int startRow = int.Parse(inputPos[0]);
            int startCol = int.Parse(inputPos[1]);
            string[] rowsAndCols = Console.ReadLine().Trim().Split();
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);

            lab = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var nextRow = Console.ReadLine().Trim().Split();
                for (int j = 0; j < cols; j++)
                {
                    if (nextRow[j] == "#")
                    {
                        lab[i, j] = -1;
                    }
                    else
                    {
                        lab[i, j] = int.Parse(nextRow[j]);
                    }
                }
            }
            Jump(startRow, startCol, 0);
            Console.WriteLine(maxPower);
        }

        static void Jump(int currentRow, int currentCol, int currentPower)
        {
            if (!CanJump(currentRow, currentCol))
            {
                return;
            }
            maxPower = Math.Max(maxPower, currentPower);

            if (lab[currentRow, currentCol] != 0)
            {
                int cellPower = lab[currentRow, currentCol];
                lab[currentRow, currentCol] = 0;
                //up
                Jump(currentRow - cellPower, currentCol, currentPower + cellPower);
                //down
                Jump(currentRow + cellPower, currentCol, currentPower + cellPower);
                //left
                Jump(currentRow, currentCol - cellPower, currentPower + cellPower);

                //right
                Jump(currentRow, currentCol + cellPower, currentPower + cellPower);

                lab[currentRow, currentCol] = cellPower;
            }
        }
        static bool CanJump(int currentRow, int currentCol)
        {
            if (currentRow < 0 || currentRow >= lab.GetLength(0))
            {
                return false;
            }
            if (currentCol < 0 || currentCol >= lab.GetLength(1))
            {
                return false;
            }
            if (lab[currentRow, currentCol] == -1)
            {
                return false;
            }
            return true;
        }
    }
}
