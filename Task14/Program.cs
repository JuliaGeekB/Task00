// Программа, которая принимает на вход число 
// и проверяет, кратно оно одновременно 7 и 23 


Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

bool MultiplicityTwoNumbers(int num)

{
    return num % 7 == 0 && num % 23 == 0;
}

if (MultiplicityTwoNumbers(number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

