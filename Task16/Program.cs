// Программа, которая принимает на вход 2 числа 
//и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите число 1:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (Square(firstNumber, secondNumber)) Console.WriteLine("Yes");
else Console.WriteLine("No");

bool Square(int num1, int num2)

{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
