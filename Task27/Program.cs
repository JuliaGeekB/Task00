// Программа, которая принимает на вход число 
// и выдает сумму цифр в числе

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine($"{sumDigits}");

int SumDigits(int num)
{
    int result = 0;
    while (num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}