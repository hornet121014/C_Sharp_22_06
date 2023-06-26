Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine()!);
int i;
if (num>=0)
{
    i = -num;
}
else
{
    i = num;
    num = -num;
}

while (i <= num)
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}

//!!!по условию задачи нужно вывести именно от -N до N, а не от N до -N
//
//int a = int.Parse(Console.ReadLine()!); //a = -6
//int count = -a; //count = 6
//    Console.WriteLine(count);
//while (count!=a){
//    if (a>0)
//    count++;//count=count+1
//    else
//    count--;//count=count-1
//    Console.WriteLine(count);
//}