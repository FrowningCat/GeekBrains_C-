using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

            Console.WriteLine("Введите число");
            int date = Convert.ToInt32(Console.ReadLine());

            if((date == 6) || (date == 7))
            {
                Console.WriteLine("Это выходной");
            } 
            else
            {
                Console.WriteLine("Это будний день");
            }
        }
    }
}
