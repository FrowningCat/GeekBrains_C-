using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            
            void minMax(double[] array)
            {
                double a = array[0];
                double b = array[0];

                for(int i = 0; i < array.Length; i++)
                {
                    if (a > array[i])
                    {
                        a = array[i];
                    }
                    if (b < array[i])
                    {
                        b = array[i];
                    }
                }
                Console.WriteLine($"Минимальный элемент массива = {a}");
                Console.WriteLine($"Максимальный элемент массива = {b}");
                Console.WriteLine($"Разница между минимальным и максимальным элементом массива = {b - a}");
            }

            double[] createArray = new double[10];
            for (int i = 0; i < createArray.Length; i++ )
            {
                createArray[i] = new Random().Next(1, 100);
                Console.Write(createArray[i] + " ");
            }
            Console.WriteLine();

            minMax(createArray);
        }
    }
}
