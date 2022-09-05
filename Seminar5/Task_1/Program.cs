using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
            // которая покажет количество чётных чисел в массиве.
            
            int[] CreateArray(int n, int start, int end)
            {
                int[] array = new int [n];
                for(int i = 0; i < n; i++)
                {
                    array[i] = new Random().Next(start, end);
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                return array;
            }

            void honest(int[] array)
            {
                int a = 0;

                for(int i = 0; i < array.Length; i++)
                {
                    if(array[i] % 2 == 0)
                    {
                        a += 1;
                    }
                }
                Console.WriteLine($"Колличество чётных элементов в массиве = {a}");
            }

            Console.WriteLine("Введите количество элементов массива");
            int num = Convert.ToInt32(Console.ReadLine());
            int max = 1000;
            int min = 100;

            int[] createArray = CreateArray(num, min, max);

            honest(createArray);
        }
    }
}
