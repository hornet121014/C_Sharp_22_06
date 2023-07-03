/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
					
void polindrom(string s)
{
	string s2=string.Empty;
	
    for(int i=s.Length-1;i>=0;i--)
	{
		s2+=s[i];
	}
	if (s==s2) Console.WriteLine("yes");
	else Console.WriteLine("no");
}

Console.Write("Input number: ");
string S = Console.ReadLine();

polindrom(S);
