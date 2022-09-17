// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3/
Console.Clear();


Console.WriteLine("Введите первое число: ");
int first_number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second_number = int.Parse(Console.ReadLine());

if (first_number > second_number)
    Console.WriteLine("Первое число больше второго ");

else if (first_number < second_number)
    Console.WriteLine("Второе число больше первого ");

else
    Console.WriteLine("Вы ввели два одинаковых числа ");