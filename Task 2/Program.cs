// программа на вход принимает два числа и выдает, какое число большее, а какое - меньшее

Console.WriteLine("введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
Console.WriteLine("число a больше числа b");
}
else if (a < b)
{
Console.WriteLine("число a меньше числа b");
}
else
{
Console.WriteLine("число a равно числу b");
}