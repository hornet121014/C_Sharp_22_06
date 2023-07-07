/*Напишите программу, которая принимает
на вход число (А) и выдаёт сумму чисел от 1 до А.*/

int sumA(int A)
{
    int result=0;
    for(int i=1; i<=A;i++)
    {
        result+=i;
    }
    return result;
}

Console.Write("Input number: ");
int num=int.Parse(Console.ReadLine()!);
Console.WriteLine(sumA(num));