﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class EmptyTile : Tile
    {
        public EmptyTile(int X, int Y) : base(X, Y)
        {
            this.tileType = TileType.Empty;

        }

    }  // Question 2.1 -EmptyTile class
}
