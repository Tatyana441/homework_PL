// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите колличество элементов в масиве: ");
int numDl = int.Parse(Console.ReadLine() ?? "");
double[] arr = new double[numDl];
Random rnd = new Random();
for (int i = 0; i < numDl; i++)
{
    arr[i] = rnd.Next(1, 100);
}

void PrintArray(double[] array)
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

double DiffNumber(double[] arr)
{
    double maxNum = arr[0];
    double minNum = arr[0];
    double result = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxNum < arr[i])
        {
            maxNum = arr[i];
        }
        if (minNum > arr[i])
        {
            minNum = arr[i];
        }
    }
    result = maxNum - minNum;
    Console.WriteLine($" - разница между максимальным и минимальным элементов массива: {result}");
    return result;
}

PrintArray(arr);
DiffNumber(arr);