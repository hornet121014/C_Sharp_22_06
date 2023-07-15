/* Задача 3: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($" {arr[i, j], 5} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNumsRandom(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(-10, 10);

    return arr;
}

void SredneArifmet(int[,] arr)
{
    double result = 0;
    double[] array2 = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
            result += arr[j, i];
        array2[i] = Math.Round(result / arr.GetLength(0), 2);
        result = 0;
    }
    Console.WriteLine("Среднее арифмитическое по столбцам: ");
    for (int i = 0; i < array2.Length; i++)
        Console.Write($" {array2[i], 5} ");
}

Console.Clear();

Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] mass = MassNumsRandom(row_num, column_num);
Console.WriteLine();

//int[,] mass = new int[3,4] { {1,4,7,2}, {5,9,2,3}, {8,4,2,4} };

PrintArray(mass);
SredneArifmet(mass);
