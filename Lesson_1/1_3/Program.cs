Console.Write("Input day of a week: ");
int num=int.Parse(Console.ReadLine()!);
switch (num)
{
    case 1:
    Console.Write("Monday");
    break;
    case 2:
    Console.Write("Tuesday");
    break;
    case 3:
    Console.Write("Wednesday");
    break;
    case 4:
    Console.Write("Thursday");
    break;
    case 5:
    Console.Write("Friday");
    break;
    case 6:
    Console.Write("Saturday");
    break;
    case 7:
    Console.Write("Sunday");
    break;
    default:
    Console.Write("Number not range 1..7");
    break;
}