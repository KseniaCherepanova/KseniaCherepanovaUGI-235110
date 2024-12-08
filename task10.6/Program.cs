using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму n (n < 100): ");
            int n = int.Parse(Console.ReadLine());
            int[] coins = { 1, 2, 5, 10 };
            List<List<int>> combinations = new List<List<int>>();

            FindCombinations(n, coins, new List<int>(), combinations);

            Console.WriteLine($"Всего способов: {combinations.Count}");
            foreach (var combination in combinations)
            {
                Console.WriteLine(string.Join(" + ", combination));
            }
            Console.ReadKey();  
        }

        static void FindCombinations(int target, int[] coins, List<int> current, List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            foreach (var coin in coins)
            {
                if (current.Count > 0 && coin < current[current.Count - 1])
                    continue; 

                if (coin <= target)
                {
                    current.Add(coin);
                    FindCombinations(target - coin, coins, current, result);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
}

