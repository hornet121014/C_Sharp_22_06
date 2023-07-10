/*Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

void massLCD(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void summ(int[] arr)
{
    int sumP = 0,
        sumO = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
            sumP += arr[i];
        else
            sumO -= arr[i];
    }
    Console.WriteLine($"Summa elements > 0 = {sumP}, Summa elements < 0 = {-sumO}");
}

int[] massR(int n)
{
    int[] mass = new int[] { };
    for (int i = 0; i < n; i++)
    {
        mass = mass.Append(new Random().Next(-9, 10)).ToArray();
    }
    return mass;
}

int N = 12;
int[] array = massR(N);
massLCD(array);
Console.WriteLine();
summ(array);