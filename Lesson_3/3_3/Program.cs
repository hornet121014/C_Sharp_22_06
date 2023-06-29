// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

void step(int num)
{
    int i=1;
    if (num<0) num=-num;
    while (i<=num)
    {
        int result=i*i;
        Console.Write(result+" ");
        i++;   
    }  
}

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine()!);
step(num);