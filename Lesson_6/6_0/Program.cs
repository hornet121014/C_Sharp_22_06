/* 0. Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void massLCD_p(int[] arr)
{
    for (int i = arr.Length-1; i >=0; i--)
    {
        Console.Write(arr[i] + " ");
    }
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
massLCD_p(array);
//Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, составляет {summaN(array)}");