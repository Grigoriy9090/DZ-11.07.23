// Console.WriteLine("Hello, World!");

// Домашнее задание: Задача 2: Напишите программу на языке C#, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее 
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine ("Ввидите первое число");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine ("Ввидите второе число");
// int b = int.Parse(Console.ReadLine());
// int max = Math.Max (a,b);
// int min = Math.Min (a,b);
// Console.WriteLine ($"Максимальное число: {max}");
// Console.WriteLine ($"Минимальное число: {min}");


// Домашнее задание: Задача 4: Напишите программу которая принимает на вход три числа и выдает 
// максимальное их этих чисел:

// Console.WriteLine ("Ввидите первое число");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine ("Ввидите второе число");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine ("Ввидите третье число");
// int c = int.Parse(Console.ReadLine());
// int max = Math.Max (a, Math.Max(b,c));
// Console.WriteLine ($"Максимальное число: {max}");

// Домашняя задача 6: Напишите программу, которая на вход принимает число и выдает, является ли 
// число четным (делится ли оно на два без остатка)

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32 (Console.ReadLine());

// if (number % 2 == 0)
// {
//     Console.WriteLine("Число является четным");
// }
// else
// {
//     Console.WriteLine("Число не является четным");
// }

// Домашняя задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от одного до N.

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите число N:");
//         int N = int.Parse(Console.ReadLine());

//         Console.WriteLine("Четные числа от 1 до " + N + ":");

//         for (int i = 1; i <= N; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }

// Новая лекция и семинар. Задача 1 найти максимальное из 9 при помощи стихийного подхода.

// int a1 = 5;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max = a1;
// if(b1>max) max=b1;
// if (c1>max) max=c1;

// if(a2>max) max=a2;
// if(b2>max) max=b2;
// if (c2>max) max=c2;

// if(a3>max) max=a3;
// if(b3>max) max=b3;
// if (c3>max) max=c3;

// Console.WriteLine(max);

// Новая лекция и семинар. Задача 1 найти максимальное из 9 при помощи функций. не работает

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 5;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 22223;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1, max2, max3);

// Console.WriteLine(max);

// Console.WriteLine("Hello, World!");

// Напишите программу, которая выводит случайное число из отрезка [от 1 до 99] 
// и показывает наибольшую цыфру числа.

// int num= new Random().Next(10,100);
// Console.WriteLine(num);
// int num1= num / 10;
// int num2= num % 10;

// if (num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else if(num1==num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }


// СЕМИНАР 2

// Напишите программу, которая выводит случайное трехзанчное  число из отрезка [от 1 до 99] 
// и удаляет среднее число.

// int num= new Random().Next(100,1000);
// Console.WriteLine(num);

// int num1= num / 100;
// int num2= num % 10;

// Console.WriteLine($"{num1}{num2}");

// Напишите программу будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число два не кратно 
// числу один, то программа выводит остаток деления.


// Console.WriteLine("Введите первое число:");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ввидите второе число: ");
// int num2=Convert.ToInt32(Console.ReadLine());

// if(num1%num2==0)
// {
//     Console.WriteLine("Кратны");
// }
// else 
// {
//     Console.WriteLine($"Число не кратно {num1%num2}");
// }

// Напишите программу которая принимает 
// на вход числои проверяет кратно оно одновремменно 7 и 23.

// Console.WriteLine("Введите число:");
// int num=Convert.ToInt32(Console.ReadLine());

// if((num%7==0)&&(num%23==0))
// {
//     Console.WriteLine("DA");
// }
// else 
// {
//     Console.WriteLine("Net");
// }

// Напишите программу которая на вход принимает два числа,
// и проверяет является ли одно число квадратом другого.

// Console.WriteLine("Введите число:");
// int number1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число:");
// int number2=Convert.ToInt32(Console.ReadLine());

// if((number1==number2*number2)||(number2==number1*number1))
// {
//     Console.WriteLine("DA");
// }
// else 
// {
//     Console.WriteLine("Net");
// }

// Домашнее задание

// Задача 10. Напишите прогрмамму которая принимает 
// на вход трехзначное число и на выходе показывает вторую цыфру этого числа.

// Console.WriteLine("Введите трехзначное число:");
// int number=Convert.ToInt32(Console.ReadLine());
// int secondDigit= ((number / 10) % 10);
// Console.WriteLine("Вторая цыфра числа:" +secondDigit);

// Задача 13. Напишите прогрмамму которая выводит третью цыфру 
// заданного числа или сообщает что третьей цыфры нет.

// Console.WriteLine("Введите число:");
// int number=Convert.ToInt32(Console.ReadLine());
// int thirdDigit=(number / 100) % 10; // Тут так не работает, ПОЧЕМУ???
// if (thirdDigit !=0)
// {
//     Console.WriteLine("Третье число:" +thirdDigit);
// }
// else
// {
//     Console.WriteLine("Третьей цыфры нет:");
// }

// Задача 15 Напишите программу которая принимает на вход цыфру,
//  заданного числа, или сообщает что третьей цыфры нет.

// Console.WriteLine("Введите число:");
// int number=Convert.ToInt32(Console.ReadLine());
// int thirdDigit=(number /100) % 10; // И тут почему не раотает ???
// if (thirdDigit !=0)
// {
//     Console.WriteLine("Третья цыфра числа: " +thirdDigit);
// }
// else
// {
//     Console.WriteLine("Третьей цыфры нет:");
// }

// Задача №17. Напишите программу, которая принимает 
// на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.

// Console.WriteLine("Введите X");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y");
// int Y = Convert.ToInt32(Console.ReadLine());

// if((X>0)&&(Y>0))  
// {
//     Console.WriteLine("1 Четверть");
// }
// else if(X<0 && Y>0)  
// {
//     Console.WriteLine("2 Четверть");
// }
// else if((X<0)&&(Y<0))  
// {
//     Console.WriteLine("3 Четверть");
// }
// else  
// {
//     Console.WriteLine("4 Четверть");
// }


// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти");
// int X = Convert.ToInt32(Console.ReadLine());

// if(X==1)  
// {
//     Console.WriteLine("x>0,y>0");
// }
// else if(X==2)  
// {
//     Console.WriteLine("Во второй четверти Х<0, Y>0");
// }
// else if(X==3)  
// {
//     Console.WriteLine("В третьей четверти X<0, Y<0");
// }
// else if(X==4)  
// {
//     Console.WriteLine("В четвертой четверти X>0, Y<0");
// }
// else  
// {
//     Console.WriteLine("Нет");
// }


// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Console.WriteLine("Введите координату");
// int X1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int Y1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int X2= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int Y2= Convert.ToInt32(Console.ReadLine());

// double result=Math.Sqrt((Math.Pow((X2-X1),2)) +  (Math.Pow((Y2-Y1),2)));

// System.Console.WriteLine(result);

// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите координату");
// int num= Convert.ToInt32(Console.ReadLine());

// for(int i=1; i<=num; i++)
// {
//    Console.WriteLine(Math.Pow(i,2));
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A(3,6,8); B (2,1,-7); -> 15.84
// A(7,-5,0); B (1,-1,9); -> 11.53

// Console.WriteLine("Введите координаты первой точки (x1, y1, z1):");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки (x2, y2, z2):");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance=Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));

// Console.WriteLine($"Расстояние между точками: {distance}");

// Домашняя задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли число палиндромом.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите пятизначное число:");
//         int number = Convert.ToInt32(Console.ReadLine());

//         bool isPalindrome = CheckPalindrome(number);
//         if (isPalindrome)
//         {
//             Console.WriteLine("Число является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Число не является палиндромом.");
//         }
//     }

//     static bool CheckPalindrome(int number)
//     {
//         // Разбиваем число на отдельные цифры
//         int digit1 = number / 10000;
//         int digit2 = (number / 1000) % 10;
//         int digit3 = (number / 100) % 10;
//         int digit4 = (number / 10) % 10;
//         int digit5 = number % 10;

//         // Проверяем, является ли число палиндромом
//         if (digit1 == digit5 && digit2 == digit4)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
// }

// Домашняя задача 23: Напишите программу, которая принимает на вход число (N) 
// и проверяет таблицу кубов чисел от 1 до (N).

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Ввидите число N:");
//         int number = Convert.ToInt32(Console.ReadLine());
//         for (int i = 1; i <= number; i++)
//         {
//             Console.WriteLine($"Таблица кубов числа N:{Math.Pow(i, 3)}");
//         }
//     }
// }

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Задача 24: Напишите программу, которая принимает на 
// вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// тип возвращающего значения + Название +()+{ }

// Задача 24: Напишите программу, которая принимает на 
// вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// тип возвращающего значения + Название +()+{ }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetSumNumber()
// {
    // int sum=0;
    // int count=1;

    // while(number>=count)
    // {
    //     sum=sum + count;
    //     count=count+1;
    // }
//     int sum =0;

//     for (int i = 0; i <= number; i++)
//     {    
//         sum=sum + i;
//     }

//     return sum;
// }

// int result=GetSumNumber();
// Console.WriteLine(result);

// Задача 26: Напишите программу, которая принимает
//  на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// тип возвращающего значения + Название +()+{ }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetCountNumber()
// {
//     int count=0;

//     while(number>0)
//     {
//         number= number/10;
//         count=count+1;
//     }
    
//     return count;
// }

// Console.WriteLine(GetCountNumber());

// Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// тип возвращающего значения + Название +()+{ }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetCountNumber()
// {
//     int result=1;

//     for (int i = 1; i <= number; i++)
//     {
//         result= result*i;
//     }
    
//     return result;
// }

// Console.WriteLine(GetCountNumber());

// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// тип возвращающего значения + Название +()+{ }
// int arrayLength =8;

// int[] array= new int[arrayLength];

// GetRandomArray();

// void GetRandomArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]= new Random().Next(0,2);
//         Console.Write(array[i]+" ");
//     }
// }

// Домашняя задача 29: Напишите программу которая задает массив из 8 элементов, и выводит их на экран

// int arrayLength =8;
// int[] array= new int[arrayLength];
// Console.Write("Массив из случайных цифр: ");
// for (int i = 0; i < arrayLength; i++)
// {
//     array[i] = new Random().Next(0,arrayLength);
//     Console.Write(array[i]+" ");
// }
// System.Console.WriteLine();
// System.Console.WriteLine();

//Домашнее задание 27: Напишите прогрмамму которая принимает на вход число, и выдает сумму цыфр в числе.

// Console.Write("Введите любое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sum = GetSumOfDigits(number);
// Console.WriteLine("Сумма цифр в числе: " + sum);

// int GetSumOfDigits(int number)
// {
// int sum = 0;
// while (number != 0)
// {
//     int digit = number % 10;
//     sum += digit;
//     number /= 10;
// }
// return sum;
// }

// Домашняя задача 25: Напишите цыкл который принимает на вход два числа (А,Б) 
// и возводит число A в натуральную степень B.

// Console.Write("Ввидите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Ввидите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// for (int i = 0; i < b; i++)
// {
//     result *= a;
// }

// Console.Write("Результат: " + result);
// System.Console.WriteLine();

// второй способ намного лучше!!!!
Console.Write("Ввидите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

double result=Math.Pow(a,b); 

Console.Write("Результат: " + result);
System.Console.WriteLine();