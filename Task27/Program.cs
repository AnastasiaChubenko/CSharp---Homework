// программа, которая принимает на вход число и выдаёт сумму цифр в числе

int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
 
int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
 
int number = Prompt("Введите число :");
Console.WriteLine($"Сумма всех цифр в числе {number} = {SumAllDigit(number)}");
