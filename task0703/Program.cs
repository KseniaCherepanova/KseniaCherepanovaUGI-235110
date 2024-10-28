using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0703
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите позицию белой фигуры");

            var whitePawnPosition = Console.ReadLine();
            int whitePawnRow, whitePawnColumn;

            DecodePosition(whitePawnPosition, out whitePawnRow, out whitePawnColumn);

            Console.WriteLine($"({whitePawnRow}; {whitePawnColumn})");

            Console.ReadLine(); 
        }

        static void DecodePosition(string position, out int x , out int y)
        {
            x = int.Parse(position[1].ToString());
            y = (int)position[0] - 0x60;
        }
    }
}
