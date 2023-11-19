﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализируем последовательность чисел
        int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

        // Находим первый положительный элемент
        int firstPositive = sequence.FirstOrDefault(n => n > 0);

        // Находим последний отрицательный элемент
        int lastNegative = sequence.LastOrDefault(n => n < 0);

        // Выводим результаты
        Console.WriteLine("Первый положительный элемент: " + firstPositive);
        Console.WriteLine("Последний отрицательный элемент: " + lastNegative);
    }
}