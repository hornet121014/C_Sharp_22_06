/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int summA(int a)
{
    int res = 0;
    if (a < 0)
        a = -1 * a;
    for (int i = 0; i < a; i++)
    {
        res += a % 10;
        a /= 10;
    }
    return res;
}

Console.Write("Input number: ");
int Num = int.Parse(Console.ReadLine()!);
Console.Write($"Summa = {summA(Num)}");