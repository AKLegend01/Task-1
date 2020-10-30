using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Mage : Enemy
    {
        public Mage(int x, int y) : base(x, y, 5, 5, 'M')
        {

        }


        public override Movement ReturnMove(Movement Move)
        {
            return 0;
        }


        public override bool CheckRange(Character Target)
        {
            if ((Target.X == x + 1) || (Target.X == x - 1) || (Target.Y == y + 1) || (Target.Y == y - 1)) return true; //x and y +- 1 seperately
            if ((Target.X == x + 1 && Target.Y == y + 1) || (Target.X == x + 1 && Target.Y == y - 1)) return true;  // x + 1 and y together
            if ((Target.X == x - 1 && Target.Y == y + 1) || (Target.X == x - 1 && Target.Y == y - 1)) return true;  // x - 1 and y together
            else return false;
           
        }

    }
}
