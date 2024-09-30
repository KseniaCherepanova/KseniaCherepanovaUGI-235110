using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadconsin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleInDigrees = 15;
            double angleInRadians = angleInDigrees * Math.PI / 180;
            var sin = Math.Sin(angleInRadians);  
            var cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin(15\x80)= " + Math.Round(sin, 3));
            Console.WriteLine("cos(15\x80)= " + Math.Round(cos, 3));

            Console.ReadKey();




           
        }
    }
}
