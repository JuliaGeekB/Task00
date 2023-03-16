// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n/

Console.WriteLine("Введите неотрицательное число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N: ");
int numberN = int.Parse(Console.ReadLine());

if (numberM < 0) Console.WriteLine("Ошибка ввода");
else if (numberN < 0) Console.WriteLine("Ошибка ввода");
else Console.WriteLine($"A({numberM}, {numberN}) = {AkkermanFunction(numberM, numberN)}");



int AkkermanFunction(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    else
      if ((num1 != 0) && (num2 == 0))
        return AkkermanFunction(num1 - 1, 1);
    else
        return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
}