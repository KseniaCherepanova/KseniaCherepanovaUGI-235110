using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadgeometrynadom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый катет");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй катет");
            var b = double.Parse(Console.ReadLine());

            var c = Math.Sqrt((a * a) + (b * b));

            var vusota = (a * b) / c;

            Console.WriteLine("Высота : " + vusota);

            Console.ReadLine();
        }
    }
}
