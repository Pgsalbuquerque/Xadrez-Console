﻿namespace board
{
    class Piece
    {
        public Position position { get; set; } 
        public Color color { get; protected set; }
        public int movements { get; protected set; }
        public Board board { get; protected set; }

        public Piece( Color color, Board board)
        {
            this.position = null;
            this.color = color;
            this.board = board;
            this.movements = 0;
        }
    }
}
