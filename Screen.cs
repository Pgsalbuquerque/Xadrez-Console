using System;
using board;

namespace Chess
{
    class Screen
    {
        public static void printBoard(Board board)
        {
            for (int l = 0; l < board.lines; l++)
            {
                Console.Write((8 - l) + " ");
                for (int c = 0; c < board.columns; c++)
                {
                    if (board.piece(l, c) == null)
                    {
                        Console.Write("- ");

                    }
                    else
                    {
                        printPiece(board.piece(l, c));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void printPiece(Piece piece)
        {
            if (piece.color == Color.WHITE)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }

        }
    }
}

