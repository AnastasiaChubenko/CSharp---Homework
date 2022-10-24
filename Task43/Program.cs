// Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения k1, b1, k2, b2 задаются пользователем.
// Например, k1 = 5, b1 = 2, k2 = 9, b2 = 4    -> (-0,5; -0,5)
 
const int Multiplier = 0;
const int Constant = 1;
const int X_coord = 0;
const int Y_coord = 1;
const int Line1 = 1;
const int Line2 = 2;
 
double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);
 
if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[Multiplier]}*x+{lineData1[Constant]} и y={lineData2[Multiplier]}*x+{lineData2[Constant]} ");
    Console.WriteLine($" имеет координаты ({coord[X_coord]}, {coord[Y_coord]})");
}
 
// Ввод числа
double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
 
// Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[Multiplier] = Prompt($"Введите коэффициент для {numberOfLine} прямой: ");
    lineData[Constant] = Prompt($"Введите константу для {numberOfLine} прямой: ");
    return lineData;
}
 
// Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_coord] = (lineData1[Constant] - lineData2[Constant]) / (lineData2[Multiplier] - lineData1[Multiplier]);
    coord[Y_coord] = lineData1[Multiplier] * coord[X_coord] + lineData1[Constant];
    return coord;
}
 
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[Multiplier] == lineData2[Multiplier])
    {
        if (lineData1[Constant] == lineData2[Constant])
        {
            Console.WriteLine("Прямые совпадают, т.е. накладываются друг на друга");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны, т.е. не пересекаются");
            return false;
        }
    }
    return true;}
