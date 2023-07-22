/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(1, 10);

    return arr;
}

int[,] ProizvMatrix(int[,] arr1, int[,] arr2)
{
    int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) != arr2.GetLength(0))
        return res;
    int item = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            item = 0;
            for (int k = 0; k < arr2.GetLength(0); k++)
                item += arr1[i, k] * arr2[k, j];
            res[i, j] = item;
        }
    }

    return res;
}

Console.Clear();

Console.Write("Введите количество строк 1й матрицы: ");
int row_num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов 1й матрицы: ");
int column_num1 = int.Parse(Console.ReadLine()!);

int[,] array1 = MassNums(row_num1, column_num1);
Console.WriteLine();
Console.WriteLine($"Матрица 1:");
PrintArray(array1);

Console.Write("Введите количество строк 2й матрицы: ");
int row_num2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов 2й матрицы: ");
int column_num2 = int.Parse(Console.ReadLine()!);

int[,] array2 = MassNums(row_num2, column_num2);
Console.WriteLine();
Console.WriteLine($"Матрица 2:");
PrintArray(array2);

/*
int[,] array1 = new int[2, 2]
{
    { 2, 4 },
    { 3, 2 }
};
int[,] array2 = new int[2, 2]
{
    { 3, 4 },
    { 3, 3 }
};
*/

Console.WriteLine($"Резултат умножения матрицы 1 на матрицу 2:");
PrintArray(ProizvMatrix(array1, array2));
