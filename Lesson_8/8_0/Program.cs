// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.

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

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(-10, 10);

    return arr;
}

int[,] ReplaceElement(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        (arr[0, j], arr[arr.GetLength(0) - 1, j]) = (arr[arr.GetLength(0) - 1, j], arr[0, j]);
    return arr;
}

Console.Clear();

Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num);
Console.WriteLine();
PrintArray(mass);

Console.WriteLine();
PrintArray(ReplaceElement(mass));
