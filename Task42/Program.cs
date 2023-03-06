// Программа, которая будет преобразовывать десятичное число в двоичное

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DecToBin(int num)
{
    int count = 1;
    int result = 0;
    while (num > 0)
    {
        result = result + num % 2 * count;
        num = num / 2;
        count *= 10;
    }
    return result;
}

int decToBin = DecToBin(number);
Console.WriteLine($"{number} -> {decToBin}");
