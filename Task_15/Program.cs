//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Введите число");
string useranswer = Console.ReadLine();
int usernumber = Convert.ToInt32(useranswer);

if (usernumber < 8 && usernumber > 0)
{

}
if (usernumber == 1)
{
  Console.WriteLine ("Понедельник - не выходной");
}
else if (usernumber == 2)
{
  Console.WriteLine ("Вторник - не выходной");
}
else if (usernumber == 3)
{
  Console.WriteLine ("Среда - не выходной");
}
else if (usernumber == 4)
{
  Console.WriteLine ("Четверг - не выходной");
}
else if (usernumber == 5)
{
  Console.WriteLine ("Пятница - не выходной");
}
else if (usernumber == 6)
{
  Console.WriteLine ("Суббота - выходной");
}
else if (usernumber == 7)
{
  Console.WriteLine ("Воскресенье - выходной");
}
else 
{
  Console.WriteLine ("Нет такого дня недели");
}