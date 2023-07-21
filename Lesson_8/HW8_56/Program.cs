/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($" {arr[i, j], 3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($" {arr[i], 3} ");
}

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(0, 10);

    return arr;
}

int[] RowSum(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];
        }
    return sum;
}

int[] FindMinRow(int[] mass, int[,] arr)
{
    int min = mass[0];
    int index = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < min)
        {
            min = mass[i];
            index = i;
        }
    }

    int[] RowMinSum = new int[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        RowMinSum[j] = arr[index, j];
    }
    return RowMinSum;
}

Console.Clear();

Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] array = MassNums(row_num, column_num);
Console.WriteLine();
PrintArray(array);

//Console.WriteLine();
//PrintMass(RowSum(array));
Console.WriteLine();
PrintMass(FindMinRow(RowSum(array), array));
