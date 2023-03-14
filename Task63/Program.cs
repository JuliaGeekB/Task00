// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.WriteLine("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num}  ");
}
