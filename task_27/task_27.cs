// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

int SummNum(int number, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;

}


Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "");
int numLen = NumberLen(num);
int numSumm = SummNum(num, numLen);
Console.WriteLine($"Сумма цифр в числе {num} равна {numSumm}");