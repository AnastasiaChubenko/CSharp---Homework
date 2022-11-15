// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] matrixA = new Int32[2, 2];
int[,] matrixB = new Int32[2, 2];
int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
/*
matrixA[0, 0] = 1;
matrixA[0, 1] = 4;
matrixA[1, 0] = 3;
matrixA[1, 1] = 5; 
matrixB[0, 0] = 3;
matrixB[0, 1] = 5;
matrixB[1, 0] = 1;
matrixB[1, 1] = 2; 
*/
randomFilling(matrixA, 1, 10);
randomFilling(matrixB, 1, 10);
arrayOutput(matrixA);
Console.WriteLine(" ");
arrayOutput(matrixB);
Console.WriteLine(" ");
arrayOutput(matrixMultiplication(matrixA, matrixB));

    int[,] matrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            throw new Exception("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
    }

void randomFilling(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}


void arrayOutput(int[,] arr)
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
