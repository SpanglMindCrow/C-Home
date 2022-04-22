// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 2;

while (numberB <= numberA)
{
    Console.Write(numberB +  ", ");
    numberB = numberB+2;
}