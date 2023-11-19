using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализируем число L и последовательность строк
        int L = 5;
        string[] sequence = { "12345", "67890", "abcde", "fghij", "klmno", "pqrst", "uvwxy", "z1234" };

        // Находим последнюю строку, начинающуюся с цифры и имеющую длину L
        string lastStringStartingWithDigit = sequence.LastOrDefault(s => char.IsDigit(s[0]) && s.Length == L);

        // Выводим результат
        if (lastStringStartingWithDigit != null)
        {
            Console.WriteLine("Последняя строка, начинающаяся с цифры и имеющая длину " + L + ": " + lastStringStartingWithDigit);
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}