// Программа, которая
// 1) выводит случайное трехзначное число
// 2) и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

int newnumber = Newnumber(number);
Console.WriteLine($"Новое число => {newnumber}");

int Newnumber(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

