// Задача 5. Напишите программу вычисления модуля числа.
// И тут Остапа понесло...

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a>=0)
{
    Console.Write(a);
}

if (a<0)
{
   a=a*(-1);
   Console.Write(a);
}