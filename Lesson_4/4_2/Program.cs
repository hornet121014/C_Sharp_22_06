// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int proizv(int num)
{
    int p=1;
    for (int i=1; i<=num;i++)
    {
        p*=i;  
    }
    return p;
}

Console.Write("Input number: ");
int N=int.Parse(Console.ReadLine()!);
Console.WriteLine(proizv(N));