using System;
Console.Clear();

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// // Создаем фунцию формирования двумерного массива вещественных чисел

// double[,] GetArray(int m, int n, int min, int max)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(max-min);
//         }
//     }
//     return result;
// }

// // Создаем фунию вывода массива на экран

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array[i,j],2) + " ");
//         }
//         Console.WriteLine();
//     }
// }

// // Вводим данные и выводим полученный результат


// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());
// double[,] mass = GetArray(m, n, 0, 10);
// PrintArray(mass);


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

// // Создаем функцию формирования двумерного целочисленного массива

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min,max);
//         }
//     }
//     return result;
// }

// // Создаем функцию вывода массива на экран

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{(array[i,j]),4}");
//         }
//         Console.WriteLine();
//     }
// }

// // Ввод данных и вывод результата

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine());

// int[,] mass = GetArray(m, n, min,max);
// PrintArray(mass);

// // Ввод данных искомого элемента, проверка наличия элемента в массиве, вывод результата на экран

// Console.WriteLine("Введите индекс элемента массива в формате [i, j]: ");
// string element = Console.ReadLine();
// string[] element = element.Split(",", StringSplitOptions.RemoveEmptyEntries);
// int[] index2 = {int.Parse(element[0]), int.Parse(element[1])};


// if (index2[0]<=mass.GetLength(0) && index2[1]<=mass.GetLength(1))
// {
//     Console.WriteLine($"Значение введенного элемента {mass[index2[0],index2[1]]}");
// }
// else Console.WriteLine("Такого элемента не существует в данном массиве");

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Создаем функцию формирования двумерного целочисленного массива

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// // Создаем функцию вывода массива на экран

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{(array[i, j]),4}");
//         }
//         Console.WriteLine();
//     }
// }

// // Создаем функцию подсчета среднего арифметического каждого столбца

// void GetArifMean(int[,]array)
// {   
//     double sum = 0;
//     double arifmean = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum = array[i, j] + sum;
//         }
//         arifmean = sum / array.GetLength(1);
//         Console.Write($"{arifmean:f2}" + " ");
//         sum = 0;
//         arifmean = 0;
//     }
// }

// // Ввод данных и вывод результата

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine());

// int[,] mass = GetArray(m, n, min, max);
// PrintArray(mass);
// GetArifMean(mass);
