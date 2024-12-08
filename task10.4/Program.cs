using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            int count = 0;
            int temp = number;
            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit == firstDigit)
                    count++;
                temp /= 10;
            }

            Console.WriteLine($"Первая цифра {firstDigit} встречается {count} раз(а).");

            Console.ReadKey();
        }
    }
}
