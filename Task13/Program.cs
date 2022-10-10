// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("введите любое целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string a_text = Convert.ToString(a);
if (a_text.Length > 2)
{
Console.WriteLine("третья цифра числа - " + a_text[2]);
}
else 
{
Console.WriteLine("третьей цифры нет");
}
