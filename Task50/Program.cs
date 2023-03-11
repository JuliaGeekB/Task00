// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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

int PromptIndexi(string message)
{
    Console.Write(message);
    int indexi = Convert.ToInt32(Console.ReadLine());
    return indexi;
}

int PromptIndexj(string message)
{
    Console.Write(message);
    int indexj = Convert.ToInt32(Console.ReadLine());
    return indexj;
}

bool RequestElement(int[,] matrix, int i, int j)
{
    if (i > matrix.GetLength(0)) return true;
    if (j > matrix.GetLength(1)) return true;
    return false;
}



int[,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);
int indexi = PromptIndexi("Введите номер строки элемента: ");
int indexj = PromptIndexj("Введите номер столбца элемента: ");
if (indexi>0 && indexj>0)
{
     bool requestElement = RequestElement(array2d, indexi, indexj);

     Console.WriteLine(requestElement ? "Такого элемента в массиве нет" : " ");
     Console.Write($"{array2d[indexi, indexj]}");
}
else Console.WriteLine ("Ошибка ввода");