using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassTasks
{
    public class Matrix<T> where T : IComparable
    {
        private int row;
        private int col;
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[this.row, this.col];
        }

        public int Row
        {
            get { return this.row; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.row = value;
            }
        }
        public int Col
        {
            get { return this.col; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.col = value;
            }
        }

        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex > this.row - 1 || rowIndex < 0 ||
                    colIndex>this.col-1 || colIndex<0)
                {
                    throw new IndexOutOfRangeException();
                }
                T result = this.matrix[rowIndex, colIndex];
                return result;
            }
            set
            {
                this.matrix[rowIndex, colIndex] = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    result.Append(string.Format("{0,5}", this.matrix[i, j]));
                }
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}
