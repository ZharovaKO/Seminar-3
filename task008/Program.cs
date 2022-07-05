// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
void palindrom (string number)
{
  if (number[0]==number[4] & number[1]==number[3])
  {
    Console.WriteLine("Да!");
  }
  else Console.WriteLine("Нет(");
}

if (number!.Length == 5)
{
    palindrom (number);
}
else Console.WriteLine("Введи пятизнанчное число!");
