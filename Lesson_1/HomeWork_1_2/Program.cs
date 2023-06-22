Console.Write("Write a number 1: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Write a number 2: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine("max = "+num1+", min = "+num2);
}
else if(num1<num2)
{
    Console.WriteLine("max = "+num2+", min = "+num1);
}
else if(num1==num2)
{
    Console.WriteLine("number 1 = number 2 = "+num1);
}