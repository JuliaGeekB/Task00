// Программа, которая задает массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран

Console.WriteLine("Сколько элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какой минимальный элемент в массиве: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какой максимальный элемент в массиве: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[] array = NewRandomArray(number, minimum, maximum);
Console.WriteLine($"Полученный массив из {number} случайных чисел");
PrintArray(array);

int[] NewRandomArray(int num, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write($",  ");
    }
    Console.Write(" -> [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write($",  ");
    }
    Console.WriteLine($"]");
}