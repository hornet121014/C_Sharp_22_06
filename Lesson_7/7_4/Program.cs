/*4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет. 
Например, такой массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 

Введенный элемент 2, результат: [1, 4] 
Введенный элемент 6, результат: такого элемента нет.*/

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
string FindElement(int[,] arr, int X)
{
    string s = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (X == arr[i, j])
                return ($"Найденный элемент находится на позиции {i + 1},{j + 1}");
        }
    }
    return "Заданного элемента нет в массиве";
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
Console.Write("Введите элемент: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(FindElement(matrix, x));
