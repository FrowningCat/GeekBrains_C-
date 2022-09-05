using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

            Console.WriteLine("Введите кординаты по х для первой точки");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кординаты по y для первой точки");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кординаты по z для первой точки");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кординаты по x для второй точки");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кординаты по y для второй точки");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кординаты по z для второй точки");
            double z2 = Convert.ToDouble(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine("Расстояние между точками А и B = " + length);
        }
    }
}
