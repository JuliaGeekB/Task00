// Задайте массив вещественных чисел.
// Найдите разницу между макс. и мин. элементами массива.

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.AwayFromZero)},  ");
        else Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.AwayFromZero)}");
    }
    Console.Write("]");
}

double MaxElement(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement = arr[i];
    }
    return Math.Round(maxElement, 1, MidpointRounding.AwayFromZero);
}

double MinElement(double[] arr)
{
    double minElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement = arr[i];
    }
    return Math.Round(minElement, 1, MidpointRounding.AwayFromZero);
}


double[] array = CreateArrayRndDouble(6, 0, 10);
PrintArrayDouble(array);
double Range = MaxElement(array) - MinElement(array);
Console.WriteLine($" -> {Math.Round(Range, 1, MidpointRounding.AwayFromZero)}");


// double maximalElement= MaxElement(array);
// Console.WriteLine($"Максимальный элемент массива -> {maximalElement}");
// double minimalElement= MinElement (array);
// Console.WriteLine($"Минимальный элемент массива -> {minimalElement}");
