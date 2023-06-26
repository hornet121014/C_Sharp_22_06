void chat(int a)
{
    if (a % 7 == 0 && a % 23 == 0)
    {
        Console.WriteLine("да");
    }
    else 
    {  
         Console.WriteLine("нет");
    }  
}
Console.Write("Введите число: ");
int NumA = int.Parse(Console.ReadLine()!);

chat(NumA);