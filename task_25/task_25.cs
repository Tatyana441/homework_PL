// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void StepGet(int number, int stepen)
{
    int result = Convert.ToInt32(Math.Pow(number, stepen));
    Console.WriteLine($"{number} в степени {stepen} = {result}");
}

int num1 = ReadData("Введите число");
int num2 = ReadData("Введите степень");
StepGet(num1, num2);