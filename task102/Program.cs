using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task102
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int n;
                if (!TryInputNumber("Введите натуральное число n (количество чисел):", out n) || n <= 0)
                {
                    Console.WriteLine("Ошибка: n должно быть натуральным числом (> 0).");
                    Console.ReadKey();
                    return;
                }

                double[] numbers = new double[n];
                Console.WriteLine("Введите числа a[0], a[1], ..., a[n-1]:");

                for (int i = 0; i < n; i++)
                {
                    if (!TryInputDouble($"Введите a[{i}]:", out numbers[i]))
                    {
                        Console.ReadKey();
                        return;
                    }
                }

                Console.WriteLine("Полученная последовательность:");
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += numbers[i];
                    Console.WriteLine(sum);
                }

                Console.ReadKey();
            }

            static bool TryInputNumber(string message, out int number)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Ошибка ввода. Введите целое число.");
                    return false;
                }

                return true;
            }

            static bool TryInputDouble(string message, out double number)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();

                if (!double.TryParse(input, out number))
                {
                    Console.WriteLine("Ошибка ввода. Введите действительное число.");
                    return false;
                }

                return true;
            

        }
    }
}
