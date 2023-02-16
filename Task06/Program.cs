// Программа, которая на вход принимает число 
// и выдает, является ли число четным
Console.WriteLine("введите число:");
int a = Convert.ToInt32(Console.ReadLine());
b=a%2*2;

if (b == a)
{
       Console.WriteLine($"Число {a} четное");
}
else
{
    Console.WriteLine($"Число {a} нечетное");
}
