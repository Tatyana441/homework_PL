// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите колличество элементов в масиве: ");
int numDl = int.Parse(Console.ReadLine() ?? "");
int[] arr = new int[numDl];
Random rnd = new Random();
for (int i = 0; i < numDl; i++)
{
    arr[i] = rnd.Next(100, 1000);
}

void PrintArray(int[] array)
{
  int count = array.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
        Console.Write(array[index]);
        index++;
        if (index < count)
        {
      Console.Write(", ");
        }
  }
  Console.Write("]");
} 

int EvenNum(int [] arr)
{ 
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
        
    }
    Console.WriteLine($" - четных чисел в массиве {count}");
    return count;
}

PrintArray(arr);
EvenNum(arr);