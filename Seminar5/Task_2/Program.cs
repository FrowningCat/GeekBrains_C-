using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

            int[] CreateArray(int n, int start, int end)
            {
                int[] array = new int[n];
                
                for(int i = 0; i < n; i++)
                {
                    array[i] = new Random().Next(start, end);
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine();
                return array;
            }

            void sumHonest(int[] array)
            {
                int a = 0;

                for(int i = 0; i < array.Length; i++)
                {
                    if(i % 2 == 0)
                    {
                        a += array[i];
                    }
                }
                Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях = {a}");
            }


            Console.WriteLine("Введите количество элементов миссива");
            int num = Convert.ToInt32(Console.ReadLine());
            int min = 1;
            int max = 10;

            int[] createArray = CreateArray(num, min, max);
            sumHonest(createArray);
        }
    }
}
