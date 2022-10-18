// Программа, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.



int Prompt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
 
// метод для получения случайных значений массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
 
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
 
int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение для диапазона случайного числа: ");
int max = Prompt("Максимальное значение для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
