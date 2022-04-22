// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int  numberA = Convert.ToInt32(Console.ReadLine());
double  numberB = numberA;
int a = ((numberA)/2);
double b = (numberB)/2;

if (a == b)
{
    Console.WriteLine("Ответ: чётное");
}
if (a > b)
{
Console.WriteLine("Ответ: не чётное");
}
if (a < b)
{
Console.WriteLine("Ответ: не чётное");
}