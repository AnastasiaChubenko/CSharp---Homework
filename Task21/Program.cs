// программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Write("Введите координату x1 первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1 первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1 первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x2 второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2 второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2 второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Round((Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))), 2);
Console.WriteLine("Расстояние между точками равно: " + result);
