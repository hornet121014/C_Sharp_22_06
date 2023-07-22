// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void PrintN(int n, int m)
{
    if (n<m) return;
    PrintN(n-1,m);
    Console.Write($"{n} ");  
}
Console.Clear();
PrintN(7,2);