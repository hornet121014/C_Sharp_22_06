/*2. Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void tochka(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 2),
            y = Math.Round(k1 * x + b1, 2);
        Console.WriteLine($"Точка пересечения прямых ({x};{y})");
    }
    else
        Console.WriteLine($"Прямые параллельны");
}

Console.Write("Введите b1: ");
double B1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
double K1 = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Уравнение первой прямой задано уравнением y = {K1} * x + {B1}");
Console.Write("Введите b2: ");
double B2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double K2 = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Уравнение второй прямой задано уравнением y = {K2} * x + {B2}");

tochka(B1, K1, B2, K2);
