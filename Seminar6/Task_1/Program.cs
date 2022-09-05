using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

            Console.Write("Введите длину массива");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a <= 0)
            {
                Console.WriteLine("Введено неверное число");
            }

            int[] arrey = new int[a];

            void CreatArrey(int a) // Заполняем массив
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write($"Введи {i+1} число: ");
                    arrey[i] = Convert.ToInt32(Console.ReadLine());
                }
            }


            int Consider(int[] arrey) // Узнаём сколько чисел > 0
            {
                int count = 0;
                for (int i = 0; i < arrey.Length; i++)
                {
                    if(arrey[i] > 0 ) count += 1; 
                }
                return count;
            }

            CreatArrey(a);

            Console.WriteLine($"Чисел больше 0: {Consider(arrey)} ");
        }
    }
}
