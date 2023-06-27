/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int abs(int num)
{
    if (num<0) return num*-1;
    return num;
}

int third_number(int num)
{
    int count=0;
    int[] array=new int[]{};
    while (num>0)
    {
        count++;
        array=array.Append(num%10).ToArray();
        num/=10;
    }
    if (count>2) return array[count-3];
    return 0;
}

Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);

if (abs(Num) > 99)
    Console.WriteLine($"Третья цифра, введенного числа, равна {third_number(abs(Num))}");
else
    Console.WriteLine(
        "Вы ввели число, в котором нет третьей цифры. Повторите попытку заново...");