using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

            void PrintNumber(int max, int min)
            {
                if (min > max) return;
                PrintNumber(max, min + 1);
                Console.Write(min + ", ");
            }

            Console.WriteLine("Введите число");
            int max = Convert.ToInt32(Console.ReadLine());
            int min = 1;

            PrintNumber(max, min);
        }
    }
}
