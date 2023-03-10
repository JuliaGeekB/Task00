// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},  ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

double[] AverageColumnElements(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] Averages = new double[size];
    for (int j = 0; j < size; j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Averages[j] = sum / matrix.GetLength(0);
    }
    return Averages;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.AwayFromZero),4},  ");
        else Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.AwayFromZero),4}");
    }
    Console.Write("]");
}


int[,] array2d = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2d);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
double[] averageColumnElements = AverageColumnElements(array2d);
PrintArray(averageColumnElements);