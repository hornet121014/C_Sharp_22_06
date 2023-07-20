// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void PrintN(int n)
{
    if (n==0) return;
    PrintN(n-1);
    Console.Write($"{n} ");  
}
Console.Clear();
PrintN(5);