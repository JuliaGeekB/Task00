// Программа, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема: каждая сторона треугольника меньше суммы двух других.

Console.WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

bool IsTriangleExists(int num1, int num2, int num3)
{
    return number1 + number2 > number3 && number2 + number3 > number1 && number1 + number3 > number2;
}

bool result = IsTriangleExists(number1, number2, number3);

Console.WriteLine(result ? "Yes" : "No");