using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
         // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

        void ArrayRandomNumbers(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
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
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int[,] matriA = new int[size, size];
        int[,] matriB = new int[size, size];
        int[,] matriC = new int[size, size];

        ArrayRandomNumbers(matriA);
        ArrayRandomNumbers(matriB);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    matriC[i, j] = matriC[i, j] + (matriA[i, k] * matriB[k, j]);
                }
            }
        }

        Console.WriteLine("Первая матрица");
        PrintArray(matriA);
        Console.WriteLine();

        Console.WriteLine("Вторая матрица");
        PrintArray(matriB);
        Console.WriteLine();

        Console.WriteLine("Произведение матриц");
        PrintArray(matriC);  
        }
    }
}
