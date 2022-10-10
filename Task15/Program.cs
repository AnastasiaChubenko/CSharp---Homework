// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());


if(a >= 1 & a <= 5)
{
Console.WriteLine("это рабочий день");
}
else if(a >= 6 & a <= 7)
{
Console.WriteLine("это выходной");
}
else
{
Console.WriteLine("нет такого дня недели");
}
