using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozdneezadanietri3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число m");

            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число n (не должно быть равно нулю)");

            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Деление на ноль невозможно.");
                return;
            }

            double result = (double)m / n;

            string resultstroka = result.ToString("F3");

            int tenths = resultstroka.Length > 2 ? resultstroka[resultstroka.IndexOf('.') + 1] - '0' : 0;
            int hundredths =   resultstroka.Length > 3 ? resultstroka[resultstroka.IndexOf('.') + 2] - '0' : 0;
            int thousandths = resultstroka.Length > 4 ? resultstroka[resultstroka.IndexOf('.') + 3] - '0' : 0;

            Console.WriteLine($"Десятые: {tenths}");
            Console.WriteLine($"Сотые: {hundredths}");
            Console.WriteLine($"Тысячные: {thousandths}");

            Console.ReadKey();
        }
    }
}
