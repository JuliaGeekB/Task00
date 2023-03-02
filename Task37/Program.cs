// Найдите произведение пар чисел в одномерном массиве.
// Парой считается 1й и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

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
        if (i < arr.Length - 1) Console.Write($"{arr[i]},  ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] CompositionNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;

    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (newArray.Length % 2 != 0)
        newArray[newArray.Length - 1] = arr[size - 1];
    return newArray;
}

int[] array = CreateArrayRndInt(8, 0, 10);
int[] array2 = CompositionNumbers(array);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);