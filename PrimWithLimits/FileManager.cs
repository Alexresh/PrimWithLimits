using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PrimWithLimits
{
    static class FileManager
    {
        public static Matrix LoadMatrixFromFile(string filename)
        {
            try
            {
                String[] input = File.ReadAllLines(filename);
                int size = input.Length;
                int[,] matrix = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    string[] items = input[i].Split(' ');
                    for (int j = 0; j < items.Length; j++)
                    {
                        matrix[i, j] = int.Parse(items[j]);
                    }
                }
                return new Matrix(matrix);
            }
            catch (Exception)
            {
                MessageBox.Show("Входной файл не соответствует синтаксису");
                return new Matrix();
            }
        }
        public static void SaveToFile(Matrix mat, string filename) 
        {
            int[,] matrix = mat.GetMatrix();
            int size = matrix.GetLength(0);
            List<string> linesToWrite = new List<string>();
            for (int i = 0; i < size; i++)
            {
                StringBuilder line = new StringBuilder();
                for (int j = 0; j < size; j++)
                    line.Append(matrix[i, j]).Append(" ");
                linesToWrite.Add(line.ToString());
            }
            try
            {
                File.WriteAllLines(filename, linesToWrite.ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось сохранить файл");
            }
        }
    }
}
