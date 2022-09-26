// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int GetNumberWeek()
{
    Console.WriteLine("Введите номер дня недели: ");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

int numberWeek = GetNumberWeek();

if (numberWeek == 1 || numberWeek == 2 || numberWeek == 3 || numberWeek == 4 || numberWeek == 5) 
    Console.WriteLine("Будний день");  
else if(numberWeek == 6 || numberWeek == 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Такого дня недели не существует");
