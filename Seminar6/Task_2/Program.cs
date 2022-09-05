using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая найдёт точку пересечения двух прямых, 
            // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

            Console.Write("Введите координату k1 ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату k2 ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату b1 ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату b1 ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            
            double x;
            double y;

            if ((k1 == k2) && (b1 == b2))
            {
                Console.Write("Прямые совпадают");
            }

            else if (k1 == k2)
            {
                Console.Write("Прямые параллельны");
            }

            else
            {
                x=(b2-b1)/(k1-k2);
                y=(k1*(b2-b1))/(k1-k2)+b1;
                Console.Write($"({x};{y})");
            }
        }
    }
}
