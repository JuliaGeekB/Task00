// Программа, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Square(number);

void Square(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index,5}-{index * index,5}");
        index++;
    }
}