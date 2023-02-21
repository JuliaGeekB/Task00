// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа


Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int secondNumber = (number /10) % 10;
    Console.Write($"Вторая цифра числа - {secondNumber}");
}
else Console.WriteLine("Вы ввели не трехзначное число!");