/* 3. Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного копирования.
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

int[] copy_massR(int[] arr)
{
    int[] copy_mass = new int[] { };
    for (int i = 0; i < arr.Length; i++)
    {
        copy_mass = copy_mass.Append(arr[i]).ToArray();
    }
    return copy_mass;
}

Console.Write("Введите количество элементов массива, N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write("Введите начальное значение диапазона для генератора случайных чисел массива: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Введите конечное значение диапазона для генератора случайных чисел массива: ");
int end = int.Parse(Console.ReadLine()!);

int[] array = massR(N, start, end);
Console.Write($"Исходный массив: ");
massLCD(array);
Console.WriteLine();
Console.Write($"Копия массива:   ");
massLCD(copy_massR(array));
