void rem(int a, int b)
{
    if (a % b == 0)
        Console.WriteLine("Числа кратны");
    else 
    {  
         Console.WriteLine("Числа не кратны. Остаток от деления равен = "+a % b);
    }
        
}
Console.Write("Введите число 1: ");
int NumA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int NumB = int.Parse(Console.ReadLine()!);
rem(NumA, NumB);