using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Item : Tile
    {
        public Item(int x, int y) : base (x, y)
        {

        }

        public override string toString()
        {
            return nameof(Item);
        }
    }
}
