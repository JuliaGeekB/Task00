// Программа, которая на вход принимает число N
// и выдает произведение чисел от 1 до N


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>0)
{
int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
}
else Console.WriteLine("Введено не целое положительное число. Повторите попытку.");

int Factorial(int num)
{
    int multiply = 1;
    for (int i = 1; i <= num; i++)
        checked
        {
            multiply = multiply * i;
        }
    return multiply;
}
