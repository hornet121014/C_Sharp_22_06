/* 1. Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

void numbers_q(int x)
{
    if (x < 1 || x>4)
        Console.WriteLine("need 1..4");
    else if (x==1) 
        Console.WriteLine("x > 0 && y > 0");
    else if (x==2)
        Console.WriteLine("x < 0 && y > 0");
    else if (x==3)
        Console.WriteLine("x < 0 && y < 0");
    else if (x==4)
        Console.WriteLine("x > 0 && y < 0");
}

Console.Write("Input quarters: ");
int num = int.Parse(Console.ReadLine()!);
numbers_q(num);