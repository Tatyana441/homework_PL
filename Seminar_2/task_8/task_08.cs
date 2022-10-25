Console.Clear();
// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число дня недели: ");
int dayWeek = int.Parse(Console.ReadLine());

int DayNumber(int dayWeek)
{

    if (dayWeek == 6 && dayWeek == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else if (dayWeek >= 1 && dayWeek <= 5)
    {
        Console.WriteLine("Будний день");
    }
    else 
    {
            Console.WriteLine("В неделе 7 дней, введите число от 1 до 7"); 
    }
    return  dayWeek;
}
DayNumber(dayWeek);