using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base (x, y, 1, 10, 'G')
        {

        }  //  Question 2.5 - recive X and Y and pass on



        public override Movement ReturnMove(Movement Move)
        {
            int move = r.Next(0, 5);
            while (tileVision[move].tileType == TileType.Empty) move = r.Next(0, 5);
            return (Movement)move;
        }
        

    }
}
