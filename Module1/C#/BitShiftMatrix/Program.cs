using System;
using System.Linq;
using System.Numerics;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());
            int[] codes = new int[moves];
            codes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            BigInteger[,] matrix = new BigInteger[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int power = rows - 1 - i + j;
                    matrix[i, j] = (BigInteger)(1)<<power;
                }
            }  
            
            int coeff = Math.Max(rows, cols);
            int currentCol = 0;
            int currentRow = rows - 1;
            BigInteger sum =matrix[currentRow,currentCol];
            matrix[currentRow, currentCol] = 0;

            for (int i = 0; i < codes.Length; i++)
            {
                int targetCol = codes[i] % coeff;
                int targetRow = codes[i] / coeff;
                int stepCol = Math.Sign(targetCol - currentCol);
                int stepRow = Math.Sign(targetRow - currentRow);

                while (targetCol != currentCol)
                {
                    currentCol += stepCol;
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = 0;
                    
                }
                while (targetRow!=currentRow)
                {
                    currentRow += stepRow;
                    sum += matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = 0;
                    
                }
            }
            Console.WriteLine(sum);


          
            //Print
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write("{0,3}", matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}
           
        }

      
    }
}
