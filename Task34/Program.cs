// Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
 
// создать массив:
int[] CreateArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;
}
 
int CountEvenElements(int[] a)
{
   
    int Count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]%2 == 0)
        {
           Count++;
        }
    }
    return Count;
}
 
//вывести массив в строку
void printArray(int[] arr)
{
    int count = 0;
    while (count < arr.Length)
    {
        Console.Write($"{arr[count]}\t");
        count++;
    }
    Console.WriteLine();
}
 
int[] array1 = CreateArray(5);
printArray(array1);
Console.WriteLine(CountEvenElements(array1));
Console.WriteLine();
