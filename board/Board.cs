using System.Data;

namespace board
{
    class Board
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;

            this.pieces = new Piece[lines, columns];
        }

        public Piece piece(int line, int column)
        {
            return this.pieces[line, column];
        }

        public Piece piece(Position pos)
        {
            return this.pieces[pos.line, pos.column];
        }

        public bool existPieceInPosition(Position pos) 
        {
            validatePosition(pos);
            return this.piece(pos) != null;
        }

        public bool checkPosition(Position pos)
        {
            if (pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!checkPosition(pos))
            {
                throw new BoardException("Invalid position!");
            }
        }

        public void insertPiece ( Piece piece, Position pos)
        {
            if (existPieceInPosition(pos)) 
            {
                throw new BoardException("There is already a piece in that position");
            }

            this.pieces[pos.line, pos.column] = piece;
            piece.position = pos;
        }
    }
}
