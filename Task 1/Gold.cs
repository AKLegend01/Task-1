using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
     class Gold : Item
    {
        private int GoldAmount;
        private Random r = new Random();

        public int GoldAmount1 { get => GoldAmount; set => GoldAmount = value; }



        public Gold(int x, int y) : base(x,y)
        {
            this.tileType = Tile.TileType.Gold;          
        }
    }
}
