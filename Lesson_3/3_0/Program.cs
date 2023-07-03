/* 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 or y=0");
    else if (x > 0 && y > 0)
        Console.WriteLine("1");
    else if (x < 0 && y > 0)
        Console.WriteLine("2");
    else if (x < 0 && y < 0)
        Console.WriteLine("3");
    else if (x > 0 && y < 0)
        Console.WriteLine("4");
}

Console.Write("Input X: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write("Input Y: ");
int Y = int.Parse(Console.ReadLine()!);
Quarters(X, Y);
