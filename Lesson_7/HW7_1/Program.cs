/* Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5  7    -2   -0,2
1   -3,3   8   -9,9
8    7,8  -7,1  9

*/
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($" {arr[i, j], 5} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double RandomDouble()
{
    int x = new Random().Next(-10, 10);
    double y = new Random().NextDouble();
    return Math.Round(x + y, 2);
}

double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = RandomDouble();

    return arr;
}
Console.Clear();

Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(row_num, column_num);
Console.WriteLine();
PrintArray(mass);
