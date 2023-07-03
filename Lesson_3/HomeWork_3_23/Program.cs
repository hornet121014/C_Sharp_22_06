/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
					
void cub(int n)
{
	if (n>0)
	{
		for(int i=1;i<=n;i++)
		{
			Console.Write(Math.Pow(i,3)+" ");
		}
	}
	else if (n<=0)
	{
		for(int i=1;i>=n;i--)
		{
			Console.Write(Math.Pow(i,3)+" ");
		}		
	}
}

Console.Write("Input N: ");
int N=int.Parse(Console.ReadLine()!);
cub(N);
