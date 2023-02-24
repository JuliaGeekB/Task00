// Программа, которая принимает на вход пятизначное число и проверяет
// является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 100000)
{
    if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10) Console.Write("Да");
    else Console.Write("Нет");
}
else Console.WriteLine("Вы ввели не пятизначное число!");
