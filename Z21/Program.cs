/* Задача 21 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53 */


Console.Clear();
Console.WriteLine("Введите Х1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите B1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Х2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y2: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите B2: ");
double b2 = double.Parse(Console.ReadLine()!);

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+Math.Pow(b1 - b2, 2));

Console.WriteLine("Расстояние = " + d);