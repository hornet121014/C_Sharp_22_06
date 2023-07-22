/* 2.Задайте двумерный массив. Найдите элементы, у которых
 обе позиции чётные, и замените эти элементы на их квадраты.
*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j], 4} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void EvenElement(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] *= arr[i, j];
        }
    }
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
EvenElement(matrix);
PrintArray(matrix);
