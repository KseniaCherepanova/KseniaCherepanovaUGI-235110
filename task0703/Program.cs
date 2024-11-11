using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Task_7._3
{
    internal class Program
    {
        private static int horseRow;
        private static int horseColumn;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого короля");
            var whiteKingPosition = Console.ReadLine();
            if (!IsPositionCorrect(whiteKingPosition))
            {
                Console.WriteLine("Некорректная позиция белого короля");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию черного коня");
            var blackHorsePosition = Console.ReadLine();
            if (!IsPositionCorrect(blackHorsePosition) ||
                whiteKingPosition == blackHorsePosition ||
                IsUnderAttack(whiteKingPosition, blackHorsePosition))
            {
                Console.WriteLine("Некорректная позиция черного коня или фигуры находятся под боем друг друга");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите предполагаемую позицию хода белого ферзя");
            var move = Console.ReadLine();
            if (CanQueenMove(move, whiteKingPosition, blackHorsePosition))
                Console.WriteLine("Ход разрешен");
            else
                Console.WriteLine("Ход запрещен");

            Console.ReadKey();
        }

        static bool IsPositionCorrect(string position)
        {
            int row, column;
            DecodePosition(position, out column, out row);
            return row >= 1 && row <= 8 && column >= 1 && column <= 8;
        }

        static bool IsUnderAttack(string whiteKingPosition, string blackHorsePosition)
        {
            int kingRow, kingColumn, horseRow, horseColumn;
            DecodePosition(whiteKingPosition, out kingColumn, out kingRow);
            DecodePosition(blackHorsePosition, out horseColumn, out horseRow);
            return (Math.Abs(kingRow - horseRow) == 2 && Math.Abs(kingColumn - horseColumn) == 1) ||
                   (Math.Abs(kingRow - horseRow) == 1 && Math.Abs(kingColumn - horseColumn) == 2);
        }

        static bool CanQueenMove(string move, string whiteQueenPosition, string blackHorsePosition)
        {
            if (!IsPositionCorrect(move)) return false;

            int queenRow, queenColumn, moveRow, moveColumn;
            DecodePosition(whiteQueenPosition, out queenColumn, out queenRow);
            DecodePosition(move, out moveColumn, out moveRow);

            // Проверка на допустимость хода ферзя
            bool isMoveCorrect = (queenRow == moveRow || queenColumn == moveColumn ||
                                  Math.Abs(queenRow - moveRow) == Math.Abs(queenColumn - moveColumn));

            // Проверка на то, что ферзь не попадает под удар коня
            bool isMoveUnderAttack = (Math.Abs(moveRow - horseRow) == 2 && Math.Abs(moveColumn - horseColumn) == 1) ||
                                      (Math.Abs(moveRow - horseRow) == 1 && Math.Abs(moveColumn - horseColumn) == 2);

            return isMoveCorrect && !isMoveUnderAttack;
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = (int)position[0] - 'a' + 1;
        }
    }
}