// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int num1 = ReadData("Введите число: ");
int num2 = ReadData("Введите степень: ");

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void DegreeGet(int number, int degree)
{
    int result = Convert.ToInt32(Math.Pow(number, degree));
    Console.WriteLine($"{number} в степени {degree} = {result}");
}

DegreeGet(num1, num2);