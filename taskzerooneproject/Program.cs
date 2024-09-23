using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskzerooneproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Малинка");

            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Что очень любит детвора");
            Console.WriteLine("Срывать с колючего куста");
            Console.WriteLine("И собирать в корзинку?");
            Console.WriteLine("Конечно же — малинку!");

            Console.ResetColor();


            Console.ReadKey();
          
        }
    }
}
