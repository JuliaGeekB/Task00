// 0. Демонстрация решения.
// Программа, которая 
// 1) на вход принимает число; 
// 2) выдает его квадрат.
// Например, 4 -> 16, -3 ->9

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
