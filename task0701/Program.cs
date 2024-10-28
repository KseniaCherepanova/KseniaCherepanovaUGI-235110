using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0701
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m = GetNumber("m");
            var n = GetNumber("n");

            if (IsReshenie(m, n))
                Console.WriteLine("Удтверждение истинно");
            else
                Console.WriteLine("Удтверждение ложно");

            Console.ReadKey();  
        }

        static bool IsReshenie(int m, int n)
        {
            return m % 2 == 0 && n % 2 == 0 && (m * n) % 2 != 0;
        }

        static int GetNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}
