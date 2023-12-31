﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализируем число D и последовательность чисел
        int D = 5;
        int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10, 25, 35, 45, -55 };

        // Извлекаем из A все нечетные положительные числа, после первого элемента A, большего D
        var extractedNumbers = sequence.SkipWhile(n => n <= D).Where(n => n > 0 && n % 2 != 0).Reverse();

        // Выводим результат
        Console.WriteLine("Извлеченные числа: " + string.Join(", ", extractedNumbers));
    }
}