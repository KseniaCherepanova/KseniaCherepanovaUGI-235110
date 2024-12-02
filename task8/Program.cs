using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x}) = {MyFunction(x)}");

            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            if (x < -2)
                return Math.Log(Math.Pow(x, 2));
            else if (x >= -2 && x <= 1)
                return Math.Exp(x); 
            else 
                return Math.Cos(x); 
        }
    }
}
