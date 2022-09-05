using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

            Console.WriteLine("введите количество строк");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] numbers = new int[x, y];

            void RandomNumbersInArray(int[,] array) // заполняем массив случайными числами
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {        
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array [i,j] = new Random().Next(0, 100)/10;
                    }   
                }
            }

            void PrintArray(int[,] array) // выводим массив
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i,j] + " ");
                    }   
                    Console.Write("]");
                    Console.WriteLine(""); 
                }
            }

            RandomNumbersInArray(numbers);

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    sum = (sum + numbers[i, j]);
                }
                sum = sum / x;
                Console.Write(sum + "; ");
            }
            Console.WriteLine();

            PrintArray(numbers);
        }
    }
}
