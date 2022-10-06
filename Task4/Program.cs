// Программа, которая принимает на вход 3 числа и выдает максимальное из этих чисел

Console.WriteLine("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
   if (b > max)
{
    max = b;
}
   if (c > max)
{
    max = c;
}
Console.WriteLine("максимальное число - "+max);
