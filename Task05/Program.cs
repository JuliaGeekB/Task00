// Программа, на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int index = - number;
while (index <= number)
{
    Console.Write(index + ", ");
    index ++;
}
