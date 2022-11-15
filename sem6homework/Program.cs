using System;


Console.Clear();

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

// Создаем функцию, которая принимает с консоли числа в формате строки и создает целочисленный массив

int[] GetNumbers(string numbers)
{
    char[] separatores = new char[] { ' ', '.', ',', ';' };
    string[] arrayNumbers = numbers.Split(separatores, StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int [arrayNumbers.Length];
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        result[i] = Convert.ToInt32(arrayNumbers[i]);
    }
    return result;
}

// Создаем функцию, которая в массиве определяет числа больше ноля 

int Count(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}

// Ввод данных от пользователя, вывод результата на экран

Console.WriteLine("Введите числа: ");
string figures = Convert.ToString(Console.ReadLine());
GetNumbers(figures);
Console.WriteLine($"[{String.Join(" ", GetNumbers(figures))}]");
Console.WriteLine("---------------");
Console.WriteLine($"Среди введенных чисел, чисел больше ноля {Count(GetNumbers(figures))} числа");
