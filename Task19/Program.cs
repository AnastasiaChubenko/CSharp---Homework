// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("введите любое пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string a_text = Convert.ToString(a);

if (a_text.Length == 5)
{
   if (a_text[0] == a_text[4] && a_text[1] == a_text[3])
   {
   Console.WriteLine("введенное число является палиндромом");
   }
   else
   {
   Console.WriteLine("введенное число НЕ является палиндромом");
   }
}

if (a_text.Length != 5)
{
  Console.WriteLine("введите именно пятизначное число");  
}
