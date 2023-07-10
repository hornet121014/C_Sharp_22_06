/*Задача 2: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве. 
4; массив [6, 7, 19, 345, 3] -> нет 
3; массив [6, 7, 19, 345, 3] -> да*/

void massLCD(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

string check_num(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return "yes";
    }
    return "no";
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

int[] array = massR(N, strat,end);
massLCD(array);
Console.WriteLine();
Console.WriteLine(check_num(array,int.Parse(Console.ReadLine()!)));