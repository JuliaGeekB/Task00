// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int c = 0;
    int[] array = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[c] = matrix[i, j];
            c += 1;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

void SumElemArray(int[] array)
{
    int count = 1;
    int currentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($"Число {currentNumber} встречается {count} раз.");
            currentNumber = array[i];
            count = 1;
        }
    }
    Console.Write($"Число {currentNumber} встречается {count} раз.");
}

// Program body------------------
int[,] matrix = CreateMatrixRndInt(3, 4, 1, 50);
int[] arr = MatrixToArray(matrix);
Console.Clear();
PrintMatrix(matrix);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();
SumElemArray(arr);