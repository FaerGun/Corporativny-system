﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализируем число K и последовательность строк
        int K = 2;
        string[] sequence = { "ABC", "DEF", "123", "GHI", "JKL", "MNO", "PQR", "STU", "VWX", "YZ0" };

        // Находим первый фрагмент последовательности
        var firstFragment = sequence.Take(3 * K);

        // Находим второй фрагмент последовательности
        var secondFragment = sequence.SkipWhile(s => !char.IsDigit(s[s.Length - 1]));

        // Находим пересечение фрагментов и удаляем дубликаты
        var intersection = firstFragment.Intersect(secondFragment).Distinct();

        // Сортируем полученную последовательность
        var sortedIntersection = intersection.OrderBy(s => s.Length).ThenBy(s => s);

        // Выводим результат
        Console.WriteLine("Отсортированная последовательность: " + string.Join(", ", sortedIntersection));
    }
}