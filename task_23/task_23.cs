// Задача 23
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int numberN = ReadData("Введите число N: ");

string lineTop = LineNumber(numberN,1);
string lineDown = LineNumber(numberN,3);

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

string LineNumber(int numN, int p)
{
    string outLine = "1";
    for (int i = 2; i <= numN; i++)
    {
        outLine = outLine + " " + Math.Pow(i, p);
    }
    return outLine;
}

PrintData("",lineTop);
PrintData("",lineDown);