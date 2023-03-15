// Программа, которая на вход принимает 2 числа и возводит число А в целую степень числа В с помощью рекурсии.

Console.WriteLine("Введите число А: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int power = int.Parse(Console.ReadLine());

int PowNumber(int num, int pow)
{
    if (pow == 0) return 1;
    else return num * PowNumber(num, pow - 1);
}

Console.WriteLine($"{number}, {power} => {PowNumber(number, power)}");