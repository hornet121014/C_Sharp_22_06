/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int one_third_number(int num)
{
    int num3=num%10;
    int num1=num/100;
    num = num1*10+num3;
    return num;
}

int Num=new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число равно {Num}");
Console.WriteLine($"Новое число, полученное из трехзначного путем удаления второй цифры, равно {one_third_number(Num)}");