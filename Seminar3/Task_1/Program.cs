using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

            Console.WriteLine("Введите пятизначное число");
            int num = Convert.ToInt32(Console.ReadLine());
            string numText = Convert.ToString(num);
            int position = 0;
            int length = 4;
            int halfLEngth = length/2;


            if((numText.Length < 5) || (numText.Length > 5))
            {
                Console.WriteLine("Введено не коректное число");
            }
            else
            {
                while (position <= halfLEngth)
                {
                    if(numText[position] == numText[length])
                    {
                        position++;
                        length--;
                    }
                    else
                    {
                        Console.WriteLine("Число не полиндром");
                        break;
                    }
                }
                if(position == 3)
                {
                    Console.WriteLine("Число полиндром");
                }
            }
        }
    }
}
