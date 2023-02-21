// Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели:");
string day = Console.ReadLine();
if (day == "1") Console.Write("Да");
else if (day == "2") Console.Write("Да");
else if (day == "3") Console.Write("Да");
else if (day == "4") Console.Write("Да");
else if (day == "5") Console.Write("Да");
else if (day == "6") Console.Write("Нет");
else if (day == "7") Console.Write("Нет");
else Console.Write("Такого дня не существует");