using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            
            int Degree(int a, int b)
            {
                int sum = 1;
                for(int i = 1; i <= b; i++)
                {
                    sum = sum * a;
                }
                return sum;
            }

            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень этого числа");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Число а в степени числа b = {Degree(a, b)}");
        }
    }
}
