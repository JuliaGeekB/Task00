// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.Write($"N = {number} -> ");
    NaturalNumbers(number);
}
else Console.WriteLine("Ошибка ввода");

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num},  ");
    NaturalNumbers(num - 1);
}
