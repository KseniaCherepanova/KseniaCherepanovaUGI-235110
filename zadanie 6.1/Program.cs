﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке");
            var text = Console.ReadLine();

            Console.WriteLine("Переводя на алфавит CS это будет: ");
            Console.WriteLine(TranslateCS(text));

            Console.ReadKey();  
        }

        static string TranslateCS(string s) 
        {
            return s
                .ToUpper()
                .Replace(" ", "  ")
                .Replace("А", "A ")
                .Replace("Б", "6 ")
                .Replace("В", "B ")
                .Replace("Г", "r ")
                .Replace("Е", "E ")
                .Replace("Ё", "E ")
                .Replace("Ж", "}|{ ")
                .Replace("З", "3 ")
                .Replace("И", "u ")
                .Replace("Й", "u* ")
                .Replace("К", "K ")
                .Replace("Л", "JI ")
                .Replace("М", "M ")
                .Replace("Н", "H ")
                .Replace("О", "O ")
                .Replace("П", "n ")
                .Replace("Р", "P ")
                .Replace("С", "C ")
                .Replace("Т", "T ")
                .Replace("У", "Y ")
                .Replace("Ф", "cp ")
                .Replace("Х", "X ")
                .Replace("Ц", " L| ")
                .Replace("Ч", "4 ")
                .Replace("Ш", "LLI ")
                .Replace("Щ", "LLL ")
                .Replace("Ъ", "b ")
                .Replace("Ы", "bI ")
                .Replace("Ь", "b ")
                .Replace("Э", "-) ")
                .Replace("Ю", "IO ")
                .Replace("Я", "9I ")

                ;

        }
    }
}
