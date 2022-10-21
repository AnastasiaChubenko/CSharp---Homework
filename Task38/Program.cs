// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// Например [3, 7.4, 22.3, 2, 78] -> 76

// создать массив:
double [] CreateArray(int length)
{
    double [] arr = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}
 
double MaxMinDiffElements(double[] a)
{
    double max = a[0];
    double min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }
         if (a[i] < min)
        {
            min = a[i];
        }
    }
    return max-min;
}
 
//вывести массив в строку:
void printArray(double[] arr)
{
    int count = 0;
    while (count < arr.Length)
    {
        Console.Write($"{arr[count]}\t");
        count++;
    }
    Console.WriteLine();
}
 
double[] array1 = CreateArray(10);
printArray(array1);
Console.WriteLine(MaxMinDiffElements(array1));
 
Console.WriteLine();
