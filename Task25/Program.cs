// Цикл, который принмает на вход два числа (А и В) 
// и возводит число А в натуральную степень В.

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
{
    int exponentiation = Exponentiation(numberA, numberB);
    Console.WriteLine($"{exponentiation}");
}
else Console.WriteLine("Ошибка ввода. Число В не целое положительное число.");

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
        checked
        {
            result = result * numA;
        }
    return result;
}
