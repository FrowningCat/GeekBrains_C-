using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            
            void ArrayRandomNumbers(int[,] array) // заполняем массив рандомными значениями
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

            Console.WriteLine("Введите количество строк");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[x, y];

            ArrayRandomNumbers(mas);
            Console.WriteLine();
            Console.WriteLine("Массив до сортировки:");
            PrintArray(mas);

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1) - 1; j++)
                {
                    for (int z = 0; z < mas.GetLength(1) - 1; z++)
                    {
                        if (mas[i, z] < mas[i, z + 1])
                        {
                            int temp = 0;
                            temp = mas[i, z];
                            mas[i, z] = mas[i, z + 1];
                            mas[i, z + 1] = temp;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Массив после сортировки");
            PrintArray(mas);
        }
    }
}
