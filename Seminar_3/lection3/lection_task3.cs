// // String Method4(int count, string text)
// // {
// //     string result = String.Empty;
// //     for (int i = 0; i < count; i++)
// //     {
// //         result = result + text;
// //     }
// //     return result;
// // }

// // string res = Method4(10, "ab");
// // Console.WriteLine(res);

// // for (int i = 2; i <= 10; i++)
// // {
// //     for (int j = 2; j <= 10; j++)
// //     {
// //         Console.WriteLine($"{i} * {j} = {i * j}");
// //     }
// //     Console.WriteLine();
// // }

// Console.Clear();

// // ===== Работа с текстом
// // Дан текст. В тексте нужно все пробелы заменить черточками,
// // маленькие буквы "к" заменить большими "К",
// // а большие "С" заменить на маленькие "с".

// // Ясна ли задача?

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послаи вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// //string s = "qwerty"
// //            012345
// //s[3] = r

// String Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// string newText1 = Replace(text, 'к', 'К');
// string newText2 = Replace(text, 'С', 'с');
// Console.WriteLine(newText + newText1 + newText2);


int ReadData(string line)
{
Console.WriteLine(line);
int number = int.Parse(Console.ReadLine() ?? "");
return number;
}

char ThirdNumChar(string inputNumber)
{
char[] simbols = inputNumber.ToCharArray();
return simbols[2];
}

int ThirdNumInt(int number)
{
int lenNum = (int)Math.Log10(number);
int outNumber = (int)(number/Math.Pow(10,lenNum-2))%10;
return outNumber;
}

void PrintData(string prefix, string value)
{
Console.WriteLine(prefix + value);
}


int number = ReadData("Введите число: ");
if (number < 100)
{
PrintData("Такой цифры нет", "");
}
else
{
char thirdSimbol = ThirdNumChar(number.ToString());
PrintData("Введенное вами число: ", thirdSimbol.ToString());

int thirdSimbolInt = ThirdNumInt(number);
PrintData("Введенное вами число: ", thirdSimbolInt.ToString());
}      