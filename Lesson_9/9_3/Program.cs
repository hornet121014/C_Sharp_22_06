// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.

int StepenN(int a, int b)
{
    //int proizv=1;
    if (b==0) return 1;
    return StepenN(a,b-1)*a; 

}
Console.Clear();
Console.Write("Введите число: ");
int A=int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int B=int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A}^{B} = {StepenN(A,B)}");