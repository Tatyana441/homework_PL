// /*
// Принимает на вход два числа и выводит, является ли второе число кратным первому, если число 2 не кратно числу 1, выводит остаток
// 34, 5 -> не кратно, остаток 4
// 36, 4 -> кратно

// */

// int GetNumber()
// {
//     Console.WriteLine("Введите числа: ");
//     string firstNumberStr = Console.ReadLine();
//     int firstNumber = int.Parse(firstNumberStr);
//     return firstNumber;
// }

// int firstNumber = GetNumber();
// int secondNumber = GetNumber();
// int result = firstNumber % secondNumber;

// if(result == 0)
// Console.WriteLine("Кратно");
// else
// Console.WriteLine($"Некратно {result}");



// вводим число, которое будет кратно 7 и 23

// int GetNumber()
// {
//     Console.WriteLine("Введите число: ");
//     string numberStr = Console.ReadLine();
//     int number = int.Parse(numberStr);
//     return number;
// }

// int numberA = GetNumber();
// if (numberA % 7 == 0 && numberA % 23 == 0)
//         Console.WriteLine("Кратно");
// else
//         Console.WriteLine("Некратно");

// Принимает на вход два числа и првоеряет, является ли одно число квадратом другого

// int GetNumber()
// {
//     Console.WriteLine("Введите число: ");
//     string numberStr = Console.ReadLine();
//     int number = int.Parse(numberStr);
//     return number;
// }
// int f_number = GetNumber();
// int s_number = GetNumber();
// f_number = Math.Abs(f_number);  // модуль 
// s_number = Math.Abs(s_number);   // модуль. по модулю неправильный код тк если ввести -4 и 16, вывод будет "квадрат"


// if (f_number > s_number )
// {
//     if (f_number / s_number == s_number)
//     Console.WriteLine("Квадрат");
//     else
//     Console.WriteLine("Не квадрат");
// }

// else if (s_number > f_number)
// {
//     if (s_number / f_number == f_number)
//     Console.WriteLine("Квадрат");
//     else
//     Console.WriteLine("Не квадрат");
// }    


// int GetNumber()
// {
// Console.WriteLine("Введите число");
// string numberStr = Console.ReadLine();
// int number = int.Parse(numberStr);
// return number;
// }

// int number1 = GetNumber();
// int number2 = GetNumber();

// if (number1 * number1 == number2 || number2 * number2 == number1)
// Console.WriteLine("Кратно");
// else
// Console.WriteLine("Не кратно");