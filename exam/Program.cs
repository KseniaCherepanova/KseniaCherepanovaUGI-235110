using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static bool IsHarshad(int number)
        {
            int sumOfNumb = 0;
            int anothernumber = number;

            while (anothernumber > 0)
            {
                sumOfNumb += anothernumber % 10;
                anothernumber /= 10;
            }

            return number % sumOfNumb == 0;
        }
        
        static int CountHarshadNumbers(int limit)
        {
            int count = 0;

            for (int i = 1; i <= limit; i++)
            {
                if (IsHarshad(i))
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int limit = 1000000; 
            int result = CountHarshadNumbers(limit);

            Console.WriteLine($"Количество чисел Харшад до {limit}: {result}");
            Console.ReadKey();
        }

    }
}
