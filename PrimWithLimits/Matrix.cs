using System;

namespace PrimWithLimits
{
    class Matrix
    {
        private int[,] matrix = { {0, 6, 5, 4,  6 },
                                  {6, 0, 8, 10, 8 },
                                  {5, 8, 0, 6,  11 },
                                  {4, 10, 6, 0, 7 },
                                  {6, 8, 11, 7, 0 } };
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
