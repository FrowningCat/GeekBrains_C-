using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

            Console.Write("Введи число");
            string thiNum = Console.ReadLine();
            if (thiNum.Length > 2)
            {
                Console.WriteLine(thiNum[2]);
            }
            else 
            {
                Console.WriteLine("третьей цифры нет");
            }
        }
    }
}
