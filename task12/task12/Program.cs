using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m (от 5 до 20):");
            int m;
            if (!TryGetNumber(out m) || m < 5 || m > 20)
            {
                Console.WriteLine("Ошибка: число m должно быть в диапазоне от 5 до 20.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число n:");
            int n;
            if (!TryGetNumber(out n) || n < 5 || n > 20)
            {
                Console.WriteLine("Ошибка: число n должно быть в диапазоне от 5 до 20.");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];
            Random random = new Random();
            FillMatrix(matrix, random);

            Console.WriteLine("\nСгенерированная матрица:");
            DisplayMatrix(matrix);

            Console.WriteLine("\nВведите число для проверки:");
            if (!TryGetNumber(out int checkNumber))
            {
                Console.ReadKey();
                return;
            }

            SearchInMatrix(matrix, checkNumber);

            Console.WriteLine("\nСреднее арифметическое для каждого столбца:");
            ComputeColumnAverages(matrix);
            Console.ReadKey();
        }

        static bool TryGetNumber(out int number)
        {
            number = 0;
            return int.TryParse(Console.ReadLine(), out number);
        }

        static void FillMatrix(int[,] matrix, Random random)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = random.Next(100);
                }
            }
        }

        static void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col],3} ");
                }
                Console.WriteLine();
            }
        }

        static void SearchInMatrix(int[,] matrix, int number)
        {
            bool isFound = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > number)
                    {
                        Console.WriteLine($"Элемент больше заданного числа найден: строка {row}, столбец {col}");
                        isFound = true;
                        return; 
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Элементов больше заданного числа нет.");
            }
        }

        static void ComputeColumnAverages(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                double total = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    total += matrix[row, col];
                }
                double average = total / matrix.GetLength(0);
                Console.WriteLine($"Столбец {col}: среднее арифметическое = {average:F2}");
            }
        }
    }
}