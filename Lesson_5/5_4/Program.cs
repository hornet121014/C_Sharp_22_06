/*Задача 4: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

void massLCD(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
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

int[] new_array(int[] arr)
{
    int length = arr.Length;
    if (length%2==0) length=arr.Length/2;
    else length=arr.Length/2 +1;
    int element = 0;
    int[] array = new int[] { };
    for (int i = 0; i < length; i++)
    {
        element++;
        if (i == arr.Length - element)
            array = array.Append(arr[i]).ToArray();
        else
            array = array.Append(arr[i] * arr[arr.Length - element]).ToArray();
    }
    return array;
}

Console.WriteLine();
int N = int.Parse(Console.ReadLine()!);
int strat = int.Parse(Console.ReadLine()!);
int end = int.Parse(Console.ReadLine()!);

int[] array = massR(N, strat, end);
massLCD(array);
Console.WriteLine();
massLCD(new_array(array));
