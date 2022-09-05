using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

            void PrintSumm(int min, int max, int sum, int maxConst)
            {
                sum = sum + max;
                if (max <= min)
                {
                    Console.Write($"Сумма элементов от {min} до {maxConst} = {sum}");
                    return;
                }
                PrintSumm(min, max - 1, sum, maxConst);
            }

            Console.WriteLine("Введите минимальное число");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное число");
            int max = Convert.ToInt32(Console.ReadLine());
            int maxConst = max;
            int sum = 0;

            PrintSumm(min, max, sum, maxConst);
        }
    }
}
