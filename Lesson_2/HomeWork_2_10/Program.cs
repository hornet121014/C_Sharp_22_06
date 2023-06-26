int two_number(int num)
{
    num = num / 10;
    return num % 10;
}
Console.Write("Введите трехзначное число: ");
int Num = int.Parse(Console.ReadLine()!);

if (Num > 99 && Num < 1000)
    Console.WriteLine($"Вторая цифра, введенного трехзначного числа, равна {two_number(Num)}");
else if (Num < -99 && Num > -1000)
    Console.WriteLine($"Вторая цифра, введенного трехзначного числа, равна {two_number(Num) * -1}");
else
    Console.WriteLine(
        "Вы ввели не число, которое не является трехзначным. Повторите попытку заново..."
    );