/* Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
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

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(-10, 10);

    return arr;
}

string FindMass(int[,] arr, int row_f, int column_f)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == row_f - 1 && j == column_f - 1)
                return ($"Значение элемента массива [{i + 1},{j + 1}] равно {arr[i, j]}");
    return "Такого элемента нет";
}

Console.Clear();

Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num);
Console.WriteLine();
PrintArray(mass);

Console.Write("Введите номер строки искомого элемента: ");
int row_find = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца искомого элемента: ");
int column_find = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(FindMass(mass, row_find, column_find));
