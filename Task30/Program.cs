// Программа, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке


Console.WriteLine("Сколько элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = NewRandomArray(number, 0, 1);
Console.WriteLine($"Полученный массив из {number}элементов");
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
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write($",  ");
    }
    Console.WriteLine($"]");
}