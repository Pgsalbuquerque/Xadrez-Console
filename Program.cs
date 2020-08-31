using System;
using board;
using chess;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.insertPiece(new Rook(Color.BLACK, board), new Position(0,0));
            board.insertPiece(new Rook(Color.BLACK, board), new Position(0, 7));
            board.insertPiece(new King(Color.BLACK, board), new Position(0, 4));
            board.insertPiece(new Rook(Color.BLACK, board), new Position(7, 7));
            board.insertPiece(new Rook(Color.BLACK, board), new Position(7, 0));
            board.insertPiece(new King(Color.BLACK, board), new Position(7, 4));

            Screen.printBoard(board);
        }
    }
}
