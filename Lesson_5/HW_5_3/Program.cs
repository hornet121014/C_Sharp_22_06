/*Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3, 7, 22, 2, 78] => 78 - 2 = 76
*/

void massLCD(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

double[] massR(int n)
{
    double[] mass = new double[] { };
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите элемент массива {i+1}: ");
        mass = mass.Append(double.Parse(Console.ReadLine()!)).ToArray();
//        mass = mass.Append(new Random().NextDouble()).ToArray();        
    }
    return mass;
}

double raznica(double[] arr)
{
    double result = 0,
           min=arr[0],
           max=arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min=arr[i];
        else if (arr[i] > max) max=arr[i];      
    }
    result=max-min;
    return result;
}

Console.Write("Введите количество элементов массива, N: ");
int N = int.Parse(Console.ReadLine()!);

double[] array = massR(N);
massLCD(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива, составляет {raznica(array)}");