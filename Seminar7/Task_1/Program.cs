using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            
            Console.WriteLine("Введите количество строк");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int y = Convert.ToInt32(Console.ReadLine());
            double[,] numbers = new double[x, y];

            void RandomNumbersInArray(double[,] array) // заполняем массив случайными числами
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                    }
                }
            }

            void PrintArray(double[,] array) // выводим массив
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "; ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }

            RandomNumbersInArray(numbers);
            PrintArray(numbers);
        }
    }
}
