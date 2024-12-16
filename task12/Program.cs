using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число n от 5 до 20");
            int n;
            if (!TryInputNumber(out n) || n < 5 || n > 20)
            {
                Console.WriteLine("Число должно быть от 5 до 20.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число m от 5 до 20");
            int m;
            if (!TryInputNumber(out m) || m < 5 || m > 20)
            {
                Console.WriteLine("Число должно быть от 5 до 20.");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];
            Random rnd = new Random();

          
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(100);
                }
            }

            PrintMatrix(matrix); 

            // ЗАДАНИЕ А
            Console.WriteLine("Введите число для поиска элементов больше него:");
            int searchValue;
            if (TryInputNumber(out searchValue))
            {
                FindElementGreaterThan(matrix, searchValue);
            }

            // ЗАДАНИЕ Б
            CalculateColumnAverages(matrix);

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            var input = Console.ReadLine();
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                return false;
            }
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],2} ");
                }
                Console.WriteLine();
            }
        }

        // МЕТОД ДЛЯ ЗАДАНИЯ А 
        static void FindElementGreaterThan(int[,] matrix, int value)
        {
            bool found = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > value)
                    {
                        Console.WriteLine($"Найден элемент больше {value}: значение {matrix[i, j]} на индексе [{i}, {j}]");
                        found = true;
                        return; 
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine($"Элементов больше {value} не найдено.");
            }
        }

        // МЕТОД ДЛЯ ЗАДАНИЯ Б
        static void CalculateColumnAverages(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }
                double average = sum / matrix.GetLength(0);
                Console.WriteLine($"Среднее арифметическое столбца {j}: {average}");
            }
        }
    }
}
