using System;

namespace Task_1
{
    public abstract class Tile
    {
        protected int y; // Question 2.1 - protected variables
        protected int x;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public enum TileType{Hero, Enemy, Gold, Weapon}; // Question 2.1 - public accessor

        public Tile()
        { 
        
        }

        public Tile(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }  // Question 2.1 -  Tile constructor



    }
}
