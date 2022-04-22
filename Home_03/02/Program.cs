//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84;  A (7,-5, 0); B (1,-1,9) -> 11.53;

Console.WriteLine("Введите координату x первой точки");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
double zB = Convert.ToDouble(Console.ReadLine());

double x=(xA-xB)*(xA-xB);
double y=(yA-yB)*(yA-yB);
double z=(zA-zB)*(zA-zB);

double c = Math.Sqrt(x + y + z);

Console.WriteLine($"Расстояние между точками равно {c}");