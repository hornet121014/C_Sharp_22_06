/* 2. Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 2D пространстве.*/

double VectorLength(int x1,int y1,int x2,int y2)
{
    return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
}

Console.Write("Input X1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Input Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Input X2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Input Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Расстояние между точками составляет "+VectorLength(X1,Y1,X2,Y2));