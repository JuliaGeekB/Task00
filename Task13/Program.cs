// Программа, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    while (number>999)
    {
        number=number/10;
    }

    int thirdDigit = number % 10;
    Console.Write($"Третья цифра числа - {thirdDigit}");
}
else Console.WriteLine("Третьей цифры нет!");
