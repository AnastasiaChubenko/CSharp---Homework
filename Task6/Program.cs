// Программа принимает на вход число и выдает, является ли оно четным

Console.WriteLine("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
   if(a%2 == 0)
{
    Console.WriteLine("введенное число является четным");
}
   else
{
    Console.WriteLine("введенное число является нечетным");
}
