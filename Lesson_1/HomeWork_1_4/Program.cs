Console.WriteLine("Input number 1, number 2, number 3: ");
int num1=int.Parse(Console.ReadLine()!),
    num2=int.Parse(Console.ReadLine()!),
    num3=int.Parse(Console.ReadLine()!),
    max=num1;
if (num2>max)
{
    max=num2;
}
if (num3>max)
{
    max=num3;
}
Console.WriteLine("max = "+max);