// Программа, которая принимает на вход координаты точки (X, Y), 
// причем X не равен 0, Y не равен )
//и выдает номер четверти плоскости, в которых находится эта точка

Console.WriteLine("Введите координаты точки");
Console.WriteLine("X:");
int xc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xc, yc);
string result = quarter > 0
     ? $"Указанные координаты соответствуют четверти {quarter}"
     : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x > 0 && y < 0) return 4;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    return 0;
}
