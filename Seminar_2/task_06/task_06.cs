// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.


// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine()??"";

// if (number.Length > 2)
// {
//     Console.WriteLine($"Третья цифра - {number[2]}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}
int number = ReadData("Введите число: ");
PrintData("Введённое вами число: ", number.ToString());