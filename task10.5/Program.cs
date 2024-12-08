using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x (процент увеличения площади): ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите y (процент средней урожайности): ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите n (требуемый общий урожай в тоннах): ");
            double n = double.Parse(Console.ReadLine());

            double area = 10; // начальная площадь
            double yieldPerHectare = 20; // начальная урожайность
            double totalYield = 0;
            int year = 0;

            while (totalYield < n * 10) // Переводим тонны в центнеры
            {
                year++;
                totalYield += area * yieldPerHectare;
                area += area * (x / 100);
                yieldPerHectare += yieldPerHectare * (y / 100);
            }

            Console.WriteLine($"Общий урожай превысит {n} тонн в {year}-й год.");
            Console.ReadKey();
        }
    }
}
