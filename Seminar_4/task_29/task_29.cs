// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// ввод элеменетов через консоль (через запятую. использовать метод string.Split())


Console.Write("Введите числа через запятую: ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string RemovingSpaces(string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

void СheckNumber2(int series)
{

    if (series == '0' || series == '1' || series == '2'
    || series == '3' || series == '4' || series == '5' || series == '6'
    || series == '7' || series == '8' || series == '9' || series == ','
    || series == '-')
    {
    }
    else
    {
        Console.WriteLine($"Ошибка ввода. Вводите цифры!");

    }
}

int[] ArrayOfNumbers(string seriesNew)
{

    int[] arrayOfNumbers = new int[1];

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            СheckNumber2(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = int.Parse(seriesNew1);
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();
        }
        j++;
    }
    return arrayOfNumbers;
}

void PrintArray(int[] vol)
{
    int count = vol.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(vol[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

PrintArray(arrayOfNumbers);