using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массивов");
            int n;

            if(!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            } 

            var numbers = new double[n];
            var rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.NextDouble();
            }

            PrintArray(numbers);

            NormaLizeArray(numbers);
            PrintArray(numbers);

            var sum = SumOfProducts(numbers);
            Console.WriteLine($"Сумма произведений a[i] * i равна {sum}");  

            Console.ReadKey();  
        }

        static void PrintArray(double[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine($"{element:F4}");

                Console.WriteLine();
            } 

        }

        static void NormaLizeArray(double[] array)
        {
            if(array == null || array.Length == 0)
                return;

            double sum = 0;

            foreach(var element in array)
                sum += element;

            for(int i = 0;i < array.Length;i++)
                array[i] /= sum;
            
        }

        static double SumOfProducts (double[] array)
        {
            if(array == null || array.Length == 0)
                return 0;

            double sum = 0;

            for(int i = 0; array.Length; i++)
            {
                sum += array[i];
            }
               
        }
    }
}
