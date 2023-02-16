// Программа, которая принимает на вход 3х зн. число и на выходе показывает последнюю цифру

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.Write($"Последняя цифра числа - {lastNumber}");
}
else Console.WriteLine ("Вы ввели не трехзначное число!");
