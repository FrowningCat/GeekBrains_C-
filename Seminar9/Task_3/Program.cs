using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

            int Akkerman(int min, int max)
            {
                if (min == 0) return max + 1;
                else if (max == 0) return Akkerman(min - 1, 1);
                else return Akkerman(min - 1, Akkerman(min, max - 1));
            }

            Console.WriteLine("Введите первое число");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int max = Convert.ToInt32(Console.ReadLine());

            int funAkkerman = Akkerman(min, max);

            Console.Write($"Функция Аккермана = {funAkkerman}");
        }
    }
}
