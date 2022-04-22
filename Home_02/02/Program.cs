//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите чило: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a>1000)
    {
        while (a>1000)
        {
            a=a/10;
        }
        if (a>999)
        {
            int b = a%10;
            Console.WriteLine(b);
        }
    }
if (a>100)
{
    int c = a%10;
    Console.WriteLine(c);
}
if (a<100)
{
    Console.WriteLine("Третьего числа нет");
}