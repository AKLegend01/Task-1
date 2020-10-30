using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class Obstacle : Tile
    {

        public Obstacle(int X, int Y) : base (X, Y)
        {
            this.tileType = TileType.obsticle;

        }  // Question 2.1 - Obstical Subclass and constructer
    }
}
