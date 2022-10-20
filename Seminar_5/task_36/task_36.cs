// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Введите колличество элементов в масиве: ");
int numDl = int.Parse(Console.ReadLine() ?? "");
int[] arr = new int[numDl];
Random rnd = new Random();
for (int i = 0; i < numDl; i++)
{
    arr[i] = rnd.Next(-100, 101);
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

int SumElement(int [] arr)
{ 
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + arr[i];
        }
        
    }
    Console.WriteLine($" - сумма элементов, стоящих на нечётных позициях: {result}");
    return result;
}

PrintArray(arr);
SumElement(arr);