// Программа,которая на вход принимает два числа 
// и выдает, какое число большее, а какое меньшее

Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());

if (a==b)
{
   Console.WriteLine($"Число {a} равно {b}");
}
else
{
    if (a > b)
    {
        Console.WriteLine($"Максимальное число {a}, Минимальное {b}");
    }
    else
    {
        Console.WriteLine($" Максимальное число {b}, Минимальное {a}");
    }
}

