/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int countP(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            result++;
    }
    return result;
}

Console.Write("Введите количество элементов массива, N: ");
int N = int.Parse(Console.ReadLine()!);

//Console.Write("Введите начальное значение диапазона для генератора случайных чисел массива: ");
//int start = int.Parse(Console.ReadLine()!);
int start = 100,
    end = 1000;

//Console.Write("Введите конечное значение диапазона для генератора случайных чисел массива: ");
//int end = int.Parse(Console.ReadLine()!);

int[] array = massR(N, start, end);
massLCD(array);
Console.WriteLine();
Console.WriteLine($"Количество четных цифр массива составляет {countP(array)}");