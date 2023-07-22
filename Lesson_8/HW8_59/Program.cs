/*Задача 59. Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
*/

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j], 3}");
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
            arr[i, j] = new Random().Next(1, 100);
    return arr;
}

int[] FindMin(int[,] arr)
{
    int[] res = new int[3];
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                res[0] = i;
                res[1] = j;
                res[2] = min;
            }
    return res;
}

void DelMin(int[,] arr, int[] mass)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == mass[0] || j == mass[1])
                continue;
            else
                Console.Write($"{arr[i, j], 3}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();

Console.Write("Введите количество строк массива: ");
int row_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] array = MassNums(row_num, column_num);
Console.WriteLine();
PrintArray(array);

Console.WriteLine(
    $"Минимальное значение массива {FindMin(array)[2]}, расположен в ячейке [{FindMin(array)[0] + 1},{FindMin(array)[1] + 1}]"
);
Console.WriteLine();
Console.WriteLine($"Резултат удаления строки и столбца минимального значения:");
Console.WriteLine();
DelMin(array, FindMin(array));
