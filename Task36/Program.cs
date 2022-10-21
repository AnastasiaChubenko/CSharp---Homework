// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример [3, 7, 23, 12] -> 19

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
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}


int SumOddPosElements(int[] a)
{
    int Sum = 0;
    for (int i = 1; i < a.Length; i = i + 2)
    {
        Sum = Sum + a[i];
    }
    return Sum;
}
 
//вывод массива в строку
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
 
int[] array1 = CreateArray(10);
printArray(array1);
Console.WriteLine(SumOddPosElements(array1));
Console.WriteLine();
