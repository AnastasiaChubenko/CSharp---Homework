// Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a >= 100 & a <= 999)
{
int first = a / 10;
int second = first % 10;
Console.WriteLine("вторая цифра числа - "+second);
}
else
{
Console.WriteLine("нужно ввести именно трехзначное число");
}
