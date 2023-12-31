﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализируем число K и последовательность чисел
        int K = 5;
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Находим первый фрагмент последовательности
        var firstFragment = sequence.Where(n => n % 2 == 0);

        // Находим второй фрагмент последовательности
        var secondFragment = sequence.Skip(K);

        // Находим разность фрагментов и удаляем дубликаты
        var difference = firstFragment.Except(secondFragment).Distinct();

        // Меняем порядок элементов на обратный
        var reversedDifference = difference.Reverse();

        // Выводим результат
        Console.WriteLine("Разность последовательностей: " + string.Join(", ", reversedDifference));
    }
}