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
                for (int c = 0; c < board.columns; c++)
                {
                    if (board.piece(l, c) == null)
                    {
                        Console.Write("- ");

                    }
                    else
                    {
                        Console.Write(board.piece(l, c) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
