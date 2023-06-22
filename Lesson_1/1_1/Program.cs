Console.Write("Write a number 1: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Write a number 2: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2 * num2)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}