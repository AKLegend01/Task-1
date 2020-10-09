using System;

namespace Task_1
{
    public abstract class Tile
    {
        protected int y; // Question 2.1 - protected variables
        protected int x;
        public enum TileType {Hero, Enemy, Gold, Weapon, Empty}; // Question 2.1 - public accessor
        protected TileType tileEnum;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public TileType TileEnum { get => tileEnum; set => tileEnum = value; }

        public Tile(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }  // Question 2.1 -  Tile constructor



    }
}
