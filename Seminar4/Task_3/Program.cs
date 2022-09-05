using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            
            Console.WriteLine("Введите длину масива");
            int a = Convert.ToInt32(Console.ReadLine());
        
            int [] numbers = new int[a];
            Console.Write("[");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers [i] = new Random().Next(0, 11);
                Console.Write(" " + i + " ");
            }
            Console.Write("]");
        }
    }
}
