// Задайте двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Methods------------------
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

int[] GetSumElemRow(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[] arr = new int[size];

    for (int z = 0; z < arr.Length; z++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
            z = i;
            arr[z] = sum;
        }

    }
    return arr;

}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},  ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int MinSumOfRow(int[] arr)
{
    int indexOfminSum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[0]) indexOfminSum = i;
    }
    return indexOfminSum;
}

// Program body------------------
int[,] array2d = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
// int[] getSumElemRow= GetSumElemRow(array2d); // вывод массива сумм элементов построчно
// PrintArray(getSumElemRow);
// Console.WriteLine();
int indexOfminSumOfRow = MinSumOfRow(getSumElemRow);
Console.WriteLine($"{indexOfminSumOfRow} строка (NB отсчет строк с 0 позиции)");
