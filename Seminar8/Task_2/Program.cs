using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

            void ArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 10);
                    }
                }
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("Введите размер массива квадрата");
            int num = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[num, num];

            ArrayRandomNumbers(numbers);
            PrintArray(numbers);

            int minimsum = Int32.MaxValue;
            int numline = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sum = sum + numbers[i, j];        
                }

                if (sum < minimsum)
                {
                    minimsum = sum;
                    numline++;
                }
            }

            Console.WriteLine("Строка с наименьшей суммой елементов: " + (numline) + ", сумма элементов: " + (minimsum));
        }
    }
}
