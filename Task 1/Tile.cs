using System;

namespace Task_1
{
    public abstract class Tile
    {
        protected int X, Y;
        public enum TileType{Hero, Enemy, Gold, Weapon};


        public Tile(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

    }
}
