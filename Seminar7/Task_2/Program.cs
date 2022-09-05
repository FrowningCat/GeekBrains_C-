using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
            // и возвращает значение этого элемента или же указание, что такого элемента нет.
            
            Console.WriteLine("введите номер строки");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите номер столбца");
            int y = Convert.ToInt32(Console.ReadLine());
            int [,] numbers = new int [10,10];

            void RandomNumbersInArray(int[,] array) // заполняем массив случайными числами
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {        
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array [i,j] = new Random().Next(-100, 100)/10;
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

            if (x > numbers.GetLength(0) || y > numbers.GetLength(1)) // проверяем на наличие в массиве
            {
                Console.WriteLine("Нет такого эллемента");
            }
            else
            {
                Console.WriteLine($"Значение элемента в строке {x} и столбце {y} равно {numbers[x-1,y-1]}");
            }

            PrintArray(numbers);
        }
    }
}
