using System;

namespace za4et
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица:");
            int sum = 0;
            int[,] matrix = { { 0, 0, 1 }, { 0, 1, 1 }, { 1, 1, 1 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
