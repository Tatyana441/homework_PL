// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

int secondNumber(int num)
{
    int result = num % 100 / 10;
    return result;
}
int res = secondNumber(number);
Console.WriteLine(res);