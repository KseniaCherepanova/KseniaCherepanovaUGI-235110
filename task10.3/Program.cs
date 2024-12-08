using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Ошибка: введите натуральное число больше 0.");
                return;
            }

            int m = 0;
            while (true)
            {
                int result = (int)Math.Pow(2, m) + (int)Math.Pow(3, m) + 1;
                if (result > n)
                {
                    Console.WriteLine($"Наименьшее число, превышающее {n}, равно {result} (при m = {m}).");
                    break;
                }
                m++;
            }
        Console.ReadKey();
        }
    }
}
