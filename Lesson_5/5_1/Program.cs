/*Задача 1: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот. 
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

void massLCD(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void massLCD_perevorot(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(-arr[i] + " ");
    }
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
massLCD_perevorot(array);