/*  1. Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой длины.
*/

void treug(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b))
        Console.Write("yes");
    else
        Console.WriteLine("no");
}

Console.Write("Input A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Input B: ");
int B = int.Parse(Console.ReadLine()!);

Console.Write("Input C: ");
int C = int.Parse(Console.ReadLine()!);

treug(A, B, C);
