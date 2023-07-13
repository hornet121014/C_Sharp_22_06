// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.

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
int EvenElement(int[,] arr)
{
    int sumA=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i==j) sumA+= arr[i, j];
        }
    }
    return sumA;
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine($"Сумма главной диагонали равна: {EvenElement(matrix)}");
