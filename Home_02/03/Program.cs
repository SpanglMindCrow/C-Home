//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите чило: ");
int a = Convert.ToInt32(Console.ReadLine());
{
if(a == 7)
{
    Console.WriteLine("Выходной, отдыхай");
}
if(a == 6)
{
    Console.WriteLine("Выходной, отдыхай");
}
if (a == 5)
{
    Console.WriteLine("Работай");
}
if (a == 4)
{
    Console.WriteLine("Работай");
}
if (a == 3)
{
    Console.WriteLine("Работай");
}
if (a == 2)
{
    Console.WriteLine("Работай");
}
}
if (a<0 || a>7)
{
    Console.WriteLine("Пожалуйста введите цифру от 1 до 7");
}