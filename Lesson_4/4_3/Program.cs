// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.

void massiv()
{
    int[] mass=new int[]{};
    for (int i=0; i<=7;i++)
    {
        mass=mass.Append(new Random().Next(0,2)).ToArray();  
    }
    for (int i=0; i<=mass.Length-1;i++)
    {
    Console.Write(mass[i]);
    }
}
massiv();