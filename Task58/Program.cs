// Задайте 2 матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(0)];

    for (int m = 0; m < newMatrix.GetLength(0); m++)
    {
        for (int n = 0; n < newMatrix.GetLength(1); n++)
        {
            newMatrix[m, n] = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                newMatrix[m, n] += matrix1[m, i] * matrix2[i, n];
            }
        }

    }
    return newMatrix;
}


// Program body------------------
Console.WriteLine("Введите количество строк в матрице1:");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице1:");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в матрице2:");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице2:");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateMatrixRndInt(row1, column1, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(row2, column2, 1, 10);
PrintMatrix(matrix2);
Console.WriteLine();
if (row1 == column2)
{
    int[,] multiplyMatrix = MultiplyMatrix(matrix1, matrix2);
    PrintMatrix(multiplyMatrix);
}
else Console.WriteLine("Умножение матриц с данными параметрами невозможно");
