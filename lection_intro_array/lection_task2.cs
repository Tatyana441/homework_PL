// // // int Max(int arg1, int arg2, int arg3)
// // // {
// // //     int result = arg1;
// // //     if (arg2 > result) result = arg2;
// // //     if (arg3 > result) result = arg3;
// // //     return result;
// // // }

// // // int[] array = {18,22,33,144,15,66,77,18,95};

// // // int result = Max(
// // //     Max(array[0], array[1], array[2]),
// // //     Max(array[3], array[4], array[5]),
// // //     Max(array[6], array[7], array[8])
// // // );
// // // Console.WriteLine(result);

// // void FillArray(int[] collection)
// // {
// //     int length = collection.Length;
// //     int index = 0;
// //     while (index < length)
// //     {
// //         collection[index] = new Random().Next(1,10);
// //         //index = index + 1
// //         index++;
// //     }
// // }

// // void PrintArray(int[] col)
// // {
// //     int count = col.Length;
// //     int position = 0;
// //     while (position < count)
// //     {
// //         Console.WriteLine(col[position]);
// //         position++;
// //     }
// // }

// // int IndexOf(int[] collection, int find)
// // {
// //     int count = collection.Length;
// //     int index = 0;
// //     int position = -1;  // вывод -1 означает, что элемент не найден
// //     while (index < count)
// //     {
// //         if(collection[index] == find)
// //         {
// //             position = index;
// //             break;
// //         }
// //         index++;
// //     }
// //     return position;
// // }

// // int[] array = new int[10];

// // FillArray(array);
// // PrintArray(array);
// // Console.WriteLine();

// // int pos = IndexOf(array, 5);
// // Console.WriteLine(pos);

// int GetRandomNumber(int leftRange, int rightRange)
// {
//     Random rnd = new Random[];
//     int result = rnd.Next(leftRange, rightRange); // [leftRange, rightRange]
//     return result;
// }

// int GetMaxDigitOfNumber(int number)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;

//     if(firstDigit > secondDigit)
//         return firstDigit;
//     else
//         return secondDigit;    
// }

// int number = GetRandomNumber(10, 100);
// Console.WriteLine($"Рандомное число: {number}");

// int maxDigit = GetMaxDigitOfNumber(number);
// Console.WriteLine($"Максимальная цифра: {maxDigit}");









// int GetRandomNumber(int leftRange, int rightRange)
// {
//     Random rnd = new Random();
//     int result = rnd.Next(leftRange, rightRange); // [leftRange, rightRange]
//     return result;
// }

// int GetMaxDigitOfNumber(int number)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;

//     if(firstDigit > secondDigit)
//         return firstDigit;
//     else
//         return secondDigit;    
// }

// int number = GetRandomNumber(10, 100);
// Console.WriteLine($"Рандомное число: {number}");

// int maxDigit = GetMaxDigitOfNumber(number);
// Console.WriteLine($"Максимальная цифра: {maxDigit}");





// int GetRandomNumber(int leftRange, int rightRange) // (100,1000)
// {
//     Random rnd = new Random();
//     int result = rnd.Next(leftRange, rightRange); // [leftRange. rightRange]
//     return result;
// }

// int DeleteSecondNumber(int number)
// {
//     int firstDigit = number / 100;
//     int thirdDigit = number % 10;
//     return firstDigit * 10 + thirdDigit;
// }

// int number = GetRandomNumber(100,1000);
// Console.WriteLine(number);

// int twoDigits = DeleteSecondNumber(number);
// Console.WriteLine(twoDigits);









