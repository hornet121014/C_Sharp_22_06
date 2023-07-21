/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

void PrintNat(int m, int n)
{
    if (m > n || m == n || n < 0)
        return;
    if (n % 2 == 0)
        PrintNat(m, n - 2);
    else
    {
        n--;
        PrintNat(m, n - 2);
    }
    Console.Write($"{n} ");
}
Console.Clear();
Console.Write("Введите m: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int N = int.Parse(Console.ReadLine()!);

if (M == N)
    Console.WriteLine(
        $"m({M}) = n({N}), такой промежуток не существует. Повторите попытку снова..."
    );
else if (M > N)
    (M, N) = (N, M);
PrintNat(M, N);
