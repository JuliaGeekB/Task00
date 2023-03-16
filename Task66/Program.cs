// Задайте значения M и N. 
// Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

if (numberM < numberN) Console.WriteLine($"{SumElementsBetweenNumbers(numberM, numberN)}");
else if (numberM > numberN) Console.WriteLine($"{SumElementsBetweenNumbers(numberN, numberM)}");
else Console.WriteLine("Ошибка ввода");


int SumElementsBetweenNumbers(int num1, int num2)
{
    if (num2 < num1) return 0;
    else return num2 + SumElementsBetweenNumbers(num1, num2 - 1);
}

