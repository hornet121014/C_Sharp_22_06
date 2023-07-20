// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int SummaN(int n)
{
    int summa=0;
    if (n/10==0) return n;
    return SummaN(n/10)+n%10; 

}
Console.Clear();
Console.Write("Введите число n: ");
int N=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа равен {SummaN(N)}");