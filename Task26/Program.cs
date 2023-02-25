// Программа, которая принмает на вход число 
// и выдает количество цифр в числе


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = CheckDigit(number);
Console.WriteLine($"В числе {number}, {digit}");

int CheckDigit(int num)
{
    int result = 0;
    if (num == 0) return 1;
    else
    {
        while (num != 0)
        {
            num = num / 10;
            result = result + 1;
        }
    }
    return result;
}
