using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число a:");
            if (!long.TryParse(Console.ReadLine(), out long a) || a <= 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var reversedDigits = RetrieveReversedDigits(a);
            DisplayArray(reversedDigits);

            Console.WriteLine("Введите значение b:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            UpdateArray(ref reversedDigits, b);
            DisplayArray(reversedDigits);

            int totalModulo10 = CalculateTotalModulo10(reversedDigits);
            Console.WriteLine($"Сумма элементов массива по модулю 10: {totalModulo10}");

            var exchangedArray = ExchangeAdjacentElements(reversedDigits);
            Console.WriteLine("Массив после обмена соседних элементов:");
            DisplayArray(exchangedArray);

            Console.ReadKey();
        }

        static int[] RetrieveReversedDigits(long value)
        {
            var digitList = new List<int>();
            while (value > 0)
            {
                digitList.Add((int)(value % 10));
                value /= 10;
            }
            return digitList.ToArray();
        }

        static void DisplayArray(int[] array)
        {
            Console.WriteLine(string.Join(";", array));
            Console.WriteLine();
        }

        static void UpdateArray(ref int[] array, int b)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (array[i] + b) % 10;
            }
        }

        static int CalculateTotalModulo10(int[] array)
        {
            int total = 0;
            foreach (var item in array)
            {
                total = (total + item) % 10;
            }
            return total;
        }

        static int[] ExchangeAdjacentElements(int[] array)
        {
            int[] newArray = (int[])array.Clone();
            for (int i = 0; i < newArray.Length - 1; i += 2)
            {
                int temporary = newArray[i];
                newArray[i] = newArray[i + 1];
                newArray[i + 1] = temporary;
            }
            return newArray;
        }
    }
}