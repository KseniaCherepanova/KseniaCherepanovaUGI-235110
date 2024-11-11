﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0702
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки (x,y) через пробел");

            var input = Console.ReadLine();
            var k =input.IndexOf(' ');
            var x = double.Parse(input.Substring(0, k));
            var y = double.Parse (input.Substring(k + 1));

            if (IsPointInArea(x, y))
                Console.WriteLine("Точка лежит в области");
            else
                Console.WriteLine("Точка не лежит в области");

            Console.ReadKey();  
        }

        static bool IsPointInArea(double x,  double y)
        {
            bool InHorixon = (x <= -2) && (y >= 1);
            return InHorixon;   
        }

           
    }
}