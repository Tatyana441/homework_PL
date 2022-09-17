// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.WriteLine("Введите первое число: ");
int f_number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int s_number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int third_number = int.Parse(Console.ReadLine());

if (f_number > s_number && f_number > third_number)
    Console.WriteLine("Самое большое число: " + f_number);

else if (s_number > f_number && s_number > third_number )
    Console.WriteLine("Самое большое число: " + s_number);

else if (third_number > f_number && third_number > s_number)
    Console.WriteLine("Самое большое число: " + third_number);

else
    Console.WriteLine("Вы ввели одинаковые числа");