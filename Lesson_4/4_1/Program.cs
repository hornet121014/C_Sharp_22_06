// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

int kolC(int num)
{
    int count=0;
    for (int i=1; num!=0;i++)
    {
        num/=10;
        count=i;
        
    }
    return count;
}

Console.Write("Input number: ");
int N=int.Parse(Console.ReadLine()!);
Console.WriteLine(kolC(N));