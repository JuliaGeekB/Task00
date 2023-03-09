// Программа, которая найдет точку пересечения 2х прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2. 
// Значения задаются пользователем.

const int COEFFICIENT=0;
const int CONSTANT=1;
const int X_COORD=0;
const int Y_COORD=1;
const int LINE1=1;
const int LINE2=2;

double[] lineData1=InputLineData(LINE1);
double[] lineData2=InputLineData(LINE2);

if (Validatelines(lineData1,lineData2))
{
    double[]coord=FindCoords(lineData1,lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]}) и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]}");
    Console.Write($"имеет координаты ({coord[X_COORD]},{coord[Y_COORD]})");
}

// Ввод числа
double Prompt(string message)
{
    Console.Write(message); // вывести сообщение
    string value = Console.ReadLine(); // считывает строку
    double result = Convert.ToDouble(value);
    return result;
}

// Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[]lineData=new double[2];
    lineData[COEFFICIENT]=Prompt($"Введите коэффициент для {numberOfLine} прямой: ");
    lineData[CONSTANT]=Prompt($"Введите константу для {numberOfLine} прямой: ");
    return lineData;
}

//поиск координат
double[]FindCoords(double[]lineData1,double[]lineData2)
{
    double[]coord=new double[2];
    coord[X_COORD]=(lineData1[CONSTANT]-lineData2[COEFFICIENT]-lineData1[COEFFICIENT]);
    coord[Y_COORD]=lineData1[CONSTANT]*coord[X_COORD]+lineData1[CONSTANT];
    return coord;
}

bool Validatelines(double[]lineData1,double[]lineData2)
{
    if (lineData1[COEFFICIENT]==lineData2[CONSTANT])
    {
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
    return true;
}

