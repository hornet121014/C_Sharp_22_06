/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 
*/

int abs(int num)
{
    if (num<0) return num*-1;
    return num;
}

int two_number(int num)
{
    num = num / 10;
    return num % 10;
}

Console.Write("Введите трехзначное число: ");
int Num = int.Parse(Console.ReadLine()!);

if (abs(Num) > 99 && abs(Num) < 1000)
    Console.WriteLine($"Вторая цифра, введенного трехзначного числа, равна {two_number(abs(Num))}");
else
    Console.WriteLine(
        "Вы ввели не число, которое не является трехзначным. Повторите попытку заново...");