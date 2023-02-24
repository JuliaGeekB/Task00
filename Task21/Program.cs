// Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты x точки a: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки a: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z точки a: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x точки b: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки b: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z точки b: ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Distance(xa, ya, za, xb, yb, zb);
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double sumSquare = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1));
    double res = Math.Sqrt(sumSquare);
    return res;
}