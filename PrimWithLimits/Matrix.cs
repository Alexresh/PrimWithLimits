using System;

namespace PrimWithLimits
{
    class Matrix
    {
        private int[,] matrix;
        /*private int[,] matrix = { {0, 3, 7, 2,  6 , 1 },
                                  {3, 0, 1, 3, 9, 6 },
                                  {7, 1, 0, 3, 5, 9 },
                                  {2, 3, 7, 0, 1, 5 },
                                  {6, 9, 5, 1, 0, 2 },
                                  {1, 6, 9, 1, 2, 0 } };*/

        public Matrix(int nodeCount)
        {
            matrix = new int[nodeCount, nodeCount];
        }

        public Matrix() 
        {
            matrix = new int[3, 3];
        }

        public Matrix(int[,] matrix) 
        {
            this.matrix = matrix.Clone() as int[,];
        }

        public int[,] GetMatrix()
        {
            return matrix;
        }

        public void SetMatrix(int[,] matrix) 
        {
            this.matrix = matrix;
        }

        public void FillRandom()
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        random.Next(1, 6);
                    }
                }
            }
        }

    }
}
