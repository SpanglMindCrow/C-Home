//Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
//Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше

Console.WriteLine("Давай поиграем. Угадай мною загаданное число от 1 до 10.");
Console.WriteLine("Готов? Тогда начинаем.");
int b = new Random().Next (1,10);
Console.WriteLine(b);
int index = 1;
while(index <= 3)
{
    Console.Write("Твой варинат ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Использовано попыток: " + index);
   
    if (a == b)
    {
        Console.WriteLine("Реально!? Ты реально угадал! Отлично, так держать!");
        break;
    }
    else if (a > b && index <3)
    {
        int ab = a - b;
        Console.WriteLine("Твоё число больше загаданного на " + ab);
        Console.WriteLine("Давай ещё раз, попробуем");
    }
    else if (a < b && index<3)
    {
        int ab = b - a;
        Console.WriteLine("Твоё число меньше загаданного на " + ab);
        Console.WriteLine("Попытка, не пытка. Попробуй ещё раз. Я верю в тебя!");
    }
else if (index == 3)
    {
    Console.WriteLine("Кажется ты проиграл");
    }
index++;
}

//да, не научилась пользоваться функциями.