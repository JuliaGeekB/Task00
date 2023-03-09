// Задайте двумерный массив размером m*n, 
// заполненный случайными вещественными числами

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(matrix[i, j], 1, MidpointRounding.AwayFromZero),4},  ");
            else Console.Write($"{Math.Round(matrix[i, j], 1, MidpointRounding.AwayFromZero),4}");
        }
        Console.WriteLine("|");
    }
}

double[,] array2d = CreateMatrixRndDouble(4, 4, -10, 10);
PrintMatrixDouble(array2d);
