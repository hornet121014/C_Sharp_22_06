/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double stepen(int a, int b)
{
    double res = 1;
    if (a == 0)
        res = 0;
    else if (a < 0 && b == 0)
        res = -1;
    else if (b < 0)
    {
        for (int i = 0; i > b; i--)
        {
            res *= a;
        }
        return 1/res;
    }
    else if (b > 0)
    {
        for (int i = 0; i < b; i++)
            res *= a;
        return res;
    }
    return res;
}

Console.Write("Input A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Input B: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write($"A^B = {stepen(A, B)}");