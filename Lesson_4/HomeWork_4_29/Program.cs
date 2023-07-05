void massLCD(int[] arr, int a, int b)
{
    if (a > arr.Length - 1 && b > arr.Length - 1)
        Console.Write("Positions large length array. Input correct positions. Try again...");
    else if (a > b)
    {
        if (a > arr.Length)
            a = arr.Length - 1;
        for (int i = a; i >= b; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
    else
    {
        b += 1;
        if (b > arr.Length)
            b = arr.Length;
        for (int i = a; i < b; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

int[] massR(int n)
{
    int[] mass = new int[] { };
    for (int i = 0; i < n; i++)
    {
        mass = mass.Append(new Random().Next(0, 100)).ToArray();
    }
    return mass;
}

Console.Write("Input length array(N>0): ");
int N = int.Parse(Console.ReadLine()!);
if (N > 0)
{
    int[] array = massR(N);
    Console.Write($"Array {0}..{N - 1}: ");
    massLCD(array, 0, array.Length);
    Console.WriteLine();

    Console.Write("Input start position: ");
    int A = int.Parse(Console.ReadLine()!);
    Console.Write("Input end position: ");
    int B = int.Parse(Console.ReadLine()!);

    Console.Write($"Array {A}..{B}: ");
    massLCD(array, A, B);
}
else
    Console.WriteLine("Input correct length array(N>0). Try again...");