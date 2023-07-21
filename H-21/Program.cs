// // Домашнее задание 34: Задайте массив заполненный случайными положительными трехзначными числами.
// // Напишите программу, которая покажет количество четных чисел в массиве.
// // пример решения 
// // [345, 897, 568, 234] -> 2

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int arrayLangth = 5;
//         int[] array = new int[arrayLangth];
//         for (int i = 0; i < arrayLangth; i++)
//         {
//             array[i] = new Random().Next(100, 1000);
//             Console.Write(array[i]+", ");
//             // (string.Join(", ", arr));
//         }
//         int count = 0;
//         foreach (int num in array)
//         {
//             if (count % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         Console.Write($"Количество четных чисел в массиве: {count}");
//         Console.WriteLine();
//     }
// }



// // Идеаотное решение

// // using System;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         // создаем массив из 10 случайных трехзначных чисел
// //         int[] arr = new int[5];
// //         Random rand = new Random();
// //         for (int i = 0; i < arr.Length; i++)
// //         {
// //             arr[i] = rand.Next(100, 1000);
// //         }
// //         Console.WriteLine(string.Join(", ", arr));

// //         // считаем количество четных чисел в массиве
// //         int count = 0;
// //         foreach (int num in arr)
// //         {
// //             if (num % 2 == 0)
// //             {
// //                 count++;
// //             }
// //         }

// //         Console.WriteLine($"Количество четных чисел в массиве: {count}");
// //     }
// // }


// // Домашняя задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6]-> 0


// // Идеальное решение:
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         // создаем массив из 4 случайных чисел
//         int[] arr = new int[4];
//         Random rand = new Random();
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = rand.Next(-10, 10);
//         }
//         Console.WriteLine(string.Join(", ", arr));

//         // считаем сумму элементов на нечетных позициях
//         int sum = 0;
//         for (int i = 1; i < arr.Length; i += 2)
//         {
//             sum += arr[i];
//         }

//         Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
//     }
// }

// // Домашняя задача 38: Задайте массив вещественных чисел.
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // создаем массив из 5 вещественных чисел
//         double[] arr = { 3.22, 4.2, 1.15, 77.15, 65.2 };
//         Console.WriteLine(string.Join(", ", arr));

//         // ищем минимальный и максимальный элементы
//         double min = arr[0];
//         double max = arr[0];
//         for (int i = 1; i < arr.Length; i++)
//         {
//             if (arr[i] < min)
//             {
//                 min = arr[i];
//             }
//             if (arr[i] > max)
//             {
//                 max = arr[i];
//             }
//         }

//         // выводим разницу между ними
//         double diff = max - min;
//         Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
//     }
// }