//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number>= 100 && number<1000)
{
int secondnumber = number / 10;
int secondnumber1 = secondnumber % 10;
Console.WriteLine(secondnumber1);
}
else
{
  Console.WriteLine("Введено не трехзначное число");
}