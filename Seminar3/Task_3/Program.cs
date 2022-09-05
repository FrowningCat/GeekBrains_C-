using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            double kub = 1;

            while(i <= num)
            {
                kub = Math.Pow(i, 3);
                Console.Write(kub + " ");
                i++;
            }
        }
    }
}
