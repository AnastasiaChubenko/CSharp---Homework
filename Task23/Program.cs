// Программа принимает на вход число N и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N > 0)
   for(int i = 1; i <= N; i++)         
   {             
       Console.Write(Math.Pow(i, 3) + " ");
   }

if(N <= 0)
   {
       Console.WriteLine("Введите число больше единицы");
   }
