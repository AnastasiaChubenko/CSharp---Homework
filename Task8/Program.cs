// Программа принимает на вход положительное число (N), а на выходе показывает все четные числа от 1 до N (включительно)

Console.WriteLine("введите положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 2; i <= N; i += 2)
Console.WriteLine(i);
if(N < 0)
{
    Console.WriteLine("вы ввели отрицательное число, а нужно положительное");
}
