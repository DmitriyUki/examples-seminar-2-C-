//Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.

int number = Random.Shared.Next();
Console.WriteLine(number);

if (number % 7 == 0 && number % 23 == 0)
{
  Console.WriteLine("кратно");
}
else
{
  Console.WriteLine("не кратно");
}