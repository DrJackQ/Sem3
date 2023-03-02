// Задача 22 

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
Console.Write($"{N} -> ");
while (count <= N)
{
    Console.Write($"{Math.Pow(count,2)}, ");
    count++;
}
