using System;
using classes;


Console.Clear();

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

// // Создаем функцию, которая принимает с консоли числа в формате строки и создает целочисленный массив

// int[] GetNumbers(string numbers)
// {
//     char[] separatores = new char[] { ' ', '.', ',', ';' };
//     string[] arrayNumbers = numbers.Split(separatores, StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int [arrayNumbers.Length];
//     for (int i = 0; i < arrayNumbers.Length; i++)
//     {
//         result[i] = Convert.ToInt32(arrayNumbers[i]);
//     }
//     return result;
// }

// // Создаем функцию, которая в массиве определяет числа больше ноля 

// int Count(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) result++;
//     }
//     return result;
// }

// // Ввод данных от пользователя, вывод результата на экран

// Console.WriteLine("Введите числа: ");
// string figures = Convert.ToString(Console.ReadLine());
// GetNumbers(figures);
// Console.WriteLine($"[{String.Join(" ", GetNumbers(figures))}]");
// Console.WriteLine("---------------");
// Console.WriteLine($"Среди введенных чисел, чисел больше ноля {Count(GetNumbers(figures))} числа");

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями:
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// Создаем функцию, которая принимает с консоли числа в формате строки и создает массив вещественных чисел

double[] GetNumbers(string numbers)
{
    char[] separatores = new char[] { ' ', '.', ',', ';' };
    string[] arrayNumbers = numbers.Split(separatores, StringSplitOptions.RemoveEmptyEntries);
    double[] result = new double [arrayNumbers.Length];
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        result[i] = Convert.ToDouble(arrayNumbers[i]);
    }
    return result;
}

// Создаем функцию, которая определяет координаты точки пересечения прямой

double[] CrossPointCoordinate(double[] array)
{
    double[] result = new double[2];
    double x = 0;
    double y1 = 0;
    double y2 = 0;
    x = (array[0] - array[2]) / (array[3] - array[1]);
    y1 = array[1] * x + array[0];
    y2 = array[3] * x + array[2];
    result[0] = Math.Round(x,2); 
    result[1] = Math.Round(y1,2);    
    return result;
}

// Вводим данные и выводим результат на экран

Console.WriteLine("Введите поочередно значения b1, k1, b2, k2");
string dates = Convert.ToString(Console.ReadLine());
double[] mass = GetNumbers(dates);
Console.WriteLine($"Координаты точки пересечения двух прямых: ({String.Join("; ", CrossPointCoordinate(mass))})");


