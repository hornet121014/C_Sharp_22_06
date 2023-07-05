/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int stepen(int a, int b)
{
    int res = 1;
    if (a == 0) res=0;
    for(int i = 1; i <= b;i++)
    {
        res*=a;
    }
    return res;
}

Console.Write("Input A: ");
int A=int.Parse(Console.ReadLine()!);
Console.Write("Input B: ");
int B=int.Parse(Console.ReadLine()!);
Console.Write($"A^B = {stepen(A,B)}");