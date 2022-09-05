using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            
            int Sum(int number, int length)
            {
                int sum = 0;
                for(int i = 1; i<=length; i++)
                {
                    sum = sum + number % 10;
                    number = number / 10;
                }
                return sum;
            }

            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            string aText = Convert.ToString(a);
            int b = Convert.ToInt32(aText.Length);

            Console.WriteLine($"Сумма чисел в числе {a} = {Sum(a, b)}");
        }
    }
}
