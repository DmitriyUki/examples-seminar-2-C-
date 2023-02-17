//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.WriteLine("Введите число 1");
int usernumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int usernumberB = Convert.ToInt32(Console.ReadLine());

int dif = usernumberA % usernumberB;

if  (dif == 0)
{
  Console.WriteLine("кратно");
}
else 
{
  Console.WriteLine($"не кратно, остаток " + dif); 
}