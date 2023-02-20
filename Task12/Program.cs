// Программа, которая принимает на вход 2 числа 
// и выводит, является ли первое число кратным второму. 
// Если 1ое число не кратно второму, то выводим остаток от деления.

Console.WriteLine("Введите число 1:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int result = Multiplicity(numberOne, numberTwo);

if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно, остаток:" + result);

int Multiplicity(int num1, int num2)
{
    return num1 % num2;
}
