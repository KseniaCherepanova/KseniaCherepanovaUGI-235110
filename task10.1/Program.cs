using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;

           
            while (true)
            {
                Console.Write("Введите число k (от 2 до 9): ");
                string input = Console.ReadLine();

                if (TryCheckOutRange(input, out k))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите целое число в диапазоне от 2 до 9.");
                }
            }

           
            Console.WriteLine($"Таблица умножения на {k}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{k} x {i} = {k * i}");
            }

            Console.ReadKey();
        }

        static bool TryCheckOutRange(string input, out int number)
        {
            return int.TryParse(input, out number) && number >= 2 && number <= 9;
        }
    }
}