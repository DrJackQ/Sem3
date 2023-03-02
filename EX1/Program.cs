// Напишите программу, которая принимает на вход координаты точки(Х и У),
// причем Х не равно 0 и У не равно 0 и выдает номер четверти плоскости, 
// в которой находится эта точка.

Console.Clear();
Console.Write("Введите Х: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите У: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else if (X == 0 || Y == 0)
{
    Console.WriteLine("На оси");
}