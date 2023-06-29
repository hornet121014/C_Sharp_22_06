/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void week_num(int num)
{
    switch (num)
    {
        case 1: 
            Console.Write("Понедельник - нет");
            break;
        case 2: 
            Console.Write("Вторник - нет");
            break;
        case 3: 
            Console.Write("Среда - нет");
            break;
        case 4: 
            Console.Write("Четверг - нет");
            break;
        case 5: 
            Console.Write("Пятница - нет");
            break;
        case 6: 
            Console.Write("Суббота - да");
            break;
        case 7: 
            Console.Write("Воскресенье - да");
            break;            
        default: 
            Console.Write("Введен некорректный день недели. Пожалуйста, введите день недели от 1 до 7. Повторите попытку заново...");
            break ;
    }
}

Console.Write("Введите число (день недели): ");
int Num = int.Parse(Console.ReadLine()!);

week_num(Num);