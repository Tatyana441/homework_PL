// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int f_num = 1;

while(f_num <= number)
{
if(f_num % 2 ==0)
    Console.Write(f_num + " ");
    f_num ++;
}

