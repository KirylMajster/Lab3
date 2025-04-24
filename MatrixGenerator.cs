using System;

namespace Lab3
{
    public static class MatrixGenerator
    {
        public static int[,] Generate(int size)
        {
            Random rand = new Random();
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = rand.Next(1, 10);
            return matrix;
        }
    }
}
