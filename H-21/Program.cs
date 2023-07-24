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

// Домашняя задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите количество чисел: ");
//         int m = int.Parse(Console.ReadLine());

//         int count = 0; // счетчик чисел больше 0
//         for (int i = 0; i < m; i++)
//         {
//             Console.Write($"Введите число {i + 1}: ");
//             int num = int.Parse(Console.ReadLine());
//             if (num > 0)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Количество чисел больше 0: {count}");
//     }
// }

// Домашняя задача 43:Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        double k2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
    }
}
