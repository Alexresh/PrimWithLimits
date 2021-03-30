using System;
using System.Linq;

namespace PrimWithLimits
{
    static class MatrixManager
    {

        public static int FindMinPos(this int[] arr)
        {
            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[pos] && arr[i] != 0)
                {
                    pos = i;
                }
            }
            return pos;
        }

        public static int FindMin(this int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min && arr[i] != 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }


        public static Position FindMinPos(this Matrix m)
        {
            int[,] matrix = m.GetMatrix();
            int[] minVector = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                minVector[i] = GetRow(m, i).FindMin();
            }

            int min = minVector.Min();
            int y = Array.IndexOf(minVector, min);
            int x = Array.IndexOf(GetRow(m, y), min);



            return new Position(x, y);

        }


        public static int[] GetRow(Matrix m, int row)
        {
            return Enumerable.Range(0, m.GetMatrix().GetLength(1))
                .Select(x => m.GetMatrix()[row, x])
                .ToArray();
        }

        public static void RemoveColumn(Matrix m, int col)
        {
            int[,] arr = m.GetMatrix();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i, col] = 0;
            }
            m.SetMatrix(arr);
        }

        public static void RemoveRow(Matrix m, int row)
        {
            int[,] arr = m.GetMatrix();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[row, i] = 0;
            }
            m.SetMatrix(arr);
        }



        public static void AddRow(Matrix m, int[] row, int pos)
        {
            int[,] arr = m.GetMatrix();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[pos, i] = row[i];
            }
        }

    }
}
