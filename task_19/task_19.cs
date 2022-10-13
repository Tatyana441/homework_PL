// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int number = ReadData("Введите пятизначное число: ");
if (number >= 10000 && number <= 99999)
{
    PalindromTest(number);
}
else
{
   Console.WriteLine("Вы ввели не пятизначное число!");
}

int PalindromTest(int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
   {
        Console.WriteLine("Число является палиндромом");
   }
   else
   {
        Console.WriteLine("Число не является палиндромом!");
   }
   return num;
}