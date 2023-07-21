/*Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int PrintNat(int m, int n)
{
    if (m > n || n < 0)
        return 0;
    return PrintNat(m, n - 1)+n;
}
Console.Clear();
Console.Write("Введите m: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int N = int.Parse(Console.ReadLine()!);

if (M < 0 && N < 0) 
    Console.WriteLine($"m({M}) = n({N}), на заданном промежутке нет натуральных чисел.");
else if (M > N)
    Console.Write(PrintNat(N, M));
else
   Console.Write(PrintNat(M, N));
