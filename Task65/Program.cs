// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке между заданными числами.

Console.WriteLine("Введите натуральное число M: ");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberTwo = int.Parse(Console.ReadLine());
PrintNumbers(numberOne, numberTwo);

void PrintNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1}  ");
        PrintNumbers(num1 - 1, num2);

    }
    else if (num2 > num1)
    {

        PrintNumbers(num1, num2 - 1);
        Console.Write($"{num2}  ");
    }
    else
    {
        Console.Write($"{num2}  ");
    }
}
