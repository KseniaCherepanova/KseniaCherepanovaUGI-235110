using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domzadanietri3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель: ");
            var m = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите знамениатель: ");
            var n = double.Parse(Console.ReadLine());

            double result = m / n;


            Console.ReadLine(result); 
            

            Console.ReadKey();  
        }
    }
}
