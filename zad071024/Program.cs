using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad071024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число x");
            var x = double.Parse(Console.ReadLine());

            var y = MyMeaning(x);   
            Console.WriteLine($"F(x) = {y}");
            
            Console.ReadKey();  
        }
        static double MyMeaning(double x)
        {
            //throw new NotImplementedException();
 
        return ((((1/(x*x + 1))+2)/((x * x + 2) + 3))/(x * x + 3));
        }
    }
}
