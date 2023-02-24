// Программа, которая принимает на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);

void Cube(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index,5}-{index * index * index,5}");
        index++;
    }
}