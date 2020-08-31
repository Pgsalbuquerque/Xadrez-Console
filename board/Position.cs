namespace board
{
    class Position
    {
        public int line { get; set; }
        public int colummn { get; set; }

        public Position(int line, int colummn)
        {
            this.line = line;
            this.colummn = colummn;
        }

        public override string ToString()
        {
            return this.line + "," + this.colummn;
        }
    }
}
