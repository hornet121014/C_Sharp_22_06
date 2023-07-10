/*Задача 3: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для 123 
[5, 18, 123, 6, 2] -> 1 
[1, 2, 3, 6, 2] -> 0 
[10, 11, 12, 13, 14] -> 5
*/

void massLCD(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int count(int[] arr, int start, int end)
{
    int count_element=0;
    for (int i = 0; i <arr.Length; i++)
    {
        if (arr[i] >=start && arr[i] <=end) count_element++;
    }
    return count_element;
}

int[] massR(int n, int a, int b)
{
    int[] mass = new int[] { };
    for (int i = 0; i < n; i++)
    {
        mass = mass.Append(new Random().Next(a, b)).ToArray();
    }
    return mass;
}
Console.WriteLine();
int N = int.Parse(Console.ReadLine()!);
int strat = int.Parse(Console.ReadLine()!);
int end = int.Parse(Console.ReadLine()!);
int position_start = 10;
int position_end = 99;

int[] array = massR(N, strat,end);
massLCD(array);
Console.WriteLine();
Console.WriteLine(count(array,position_start,position_end));