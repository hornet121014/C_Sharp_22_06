// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз
//    встречается элемент входных данных. Значения элементов массива 0..9
//    https://metanit.com/sharp/tutorial/4.9.php

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

void PrintArrayMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"Цифра {i} = {arr[i]} раз");
}

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(0, 10);

    return arr;
}

int[] FrequencyDict(int[,] arr)
{
    int[] freq = new int[10];

    foreach (var i in arr)
    {
        freq[i]++;
    }
    return freq;
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
PrintArrayMass(FrequencyDict(mass));
