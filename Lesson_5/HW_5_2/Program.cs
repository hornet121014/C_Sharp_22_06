/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 4, 67] -> 0
*/

void massLCD(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] massR(int n, int a, int b)
{
    int[] mass = new int[] { };
    for (int i = 0; i < n; i++)
    {
        mass = mass.Append(new Random().Next(a, b)).ToArray();
    }
    return mass;
}

int summaN(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        result+=arr[i];
    }
    return result;
}

Console.Write("Введите количество элементов массива, N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write("Введите начальное значение диапазона для генератора случайных чисел массива: ");
int start = int.Parse(Console.ReadLine()!);
//int start = 100,
//    end = 1000;

Console.Write("Введите конечное значение диапазона для генератора случайных чисел массива: ");
int end = int.Parse(Console.ReadLine()!);

int[] array = massR(N, start, end);
massLCD(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, составляет {summaN(array)}");