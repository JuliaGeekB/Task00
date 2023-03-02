// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int GetSumOddIndexElements(int[] arr)
{
    int sumOddIndex = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sumOddIndex = sumOddIndex + arr[i];
    }
    return sumOddIndex;
}

int[] array = CreateArrayRndInt(6, -10, 10);
PrintArray(array);
int sumOddIndexElements = GetSumOddIndexElements(array);
Console.WriteLine($" -> {sumOddIndexElements}");
