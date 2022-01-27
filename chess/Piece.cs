using System;

namespace project2
{
    class Piece
    {
        private String Name;
        public String Image { get; }

        public Piece(String Name, String Image)
        {
            this.Name = Name;
            this.Image = Image;
        }
    }
}
