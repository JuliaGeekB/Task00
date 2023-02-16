// Программа, которая принимает на вход три числа 
// и выдает максимальное из этих числе

Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3:");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    if (a>c)
    {
        Console.WriteLine($"Максимальное число {a}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {c}");
    }
}
else
{
    if (b>c)
    {
        Console.WriteLine($"Максимальное число {b}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {c}");
    }
}