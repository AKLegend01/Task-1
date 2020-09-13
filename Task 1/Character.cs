using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Character : Tile
    {
        int x, y;
        protected int HP, MaxHP, Damage;
        public string[] Tile = new string[4];
        public enum Movement {None, Up, Down, Left, Right};

        public Character() : base(x, y)
        {

        }
        
            
            
        
    }
}
