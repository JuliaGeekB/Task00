﻿// Программа, которая на вход принимает число 
// и выдает, является ли число четным
Console.WriteLine("введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} является четным");
}
else
{
    Console.WriteLine($"Число {a} не является четным");
}
