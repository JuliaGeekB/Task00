// Программа, которая задает массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран

Console.WriteLine("Сколько элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = NewRandomArray(number);
Console.WriteLine($"Полученный массив из {number}элементов");
PrintArray(array);

int[] NewRandomArray(int num)
{
    Random rand = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand.Next();
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write($",  ");
    }
    Console.WriteLine($"]");
}