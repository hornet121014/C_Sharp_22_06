﻿/* 1. Пользователь вводит с клавиатуры М чисел.
Посчитайте, сколько чисел больше 0 ввел пользователь.
Ввод чисел с клавиатуры прекратить при вводе 0.
7,8,-2,-2,0 ->2
-1,-7,567,89,223 ->3
*/

int zero()
{
    int count = 0;

    while (true)
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0)
            count++;
        else if (num == 0)
            break;
    }
    return count;
}

Console.WriteLine($"Количество введенных положительных чисел, составляет {zero()}");
