// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 100 && number <=999)
    Console.WriteLine(number % 100 / 10);
else
    Console.WriteLine("Это не трёхзначное число");
