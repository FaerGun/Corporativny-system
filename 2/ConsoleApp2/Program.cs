﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализируем цифру D и последовательность чисел
        int D = 5;
        int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10, 25, 35, 45, -55 };

        // Находим первый положительный элемент, оканчивающийся цифрой D
        int firstPositiveEndingWithD = sequence.Where(n => n > 0 && n % 10 == D).FirstOrDefault();

        // Выводим результат
        Console.WriteLine("Первый положительный элемент, оканчивающийся цифрой " + D + ": " + firstPositiveEndingWithD);
    }
}