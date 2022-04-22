// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int a1 = N/10000;
double a2 = (N/1000)%10;

double b1 = N%10;
double b2 = (N%100)/10;

if ((a1 == b1) && (a2 ==b2))
{
    Console.WriteLine($"{N} является палиндромом");
}
else
{
    Console.WriteLine($"{N} не является палиндромом");
}