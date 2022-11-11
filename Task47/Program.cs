// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] array = new Double[5, 3];

randomFilling(array);
arrayOutput(array);

void randomFilling(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((new Random().NextDouble() * 100), 1);
        }
    }
}


void arrayOutput(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine(" ");
    }
}
