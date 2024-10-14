using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("дите действительно число x");
            var x = double.Parse(Console.ReadLine());

            var y = MyFunction(x);  
            Console.WriteLine($"f(x) = {y}");   
            Console.ReadKey();  
        }

        static double MyFunction(double x)
        {
            return (1 / (1 + (1 / (2 + 1 / (3 + Math.Sqrt(5))))));
        }
    }
}
