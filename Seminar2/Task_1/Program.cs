using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            
            Console.WriteLine("Введите трёхзначное число");
            int num = Convert.ToInt32(Console.ReadLine());

            int secNum = num / 10;
            secNum = secNum % 10;

            Console.WriteLine(secNum);
        }
    }
}
