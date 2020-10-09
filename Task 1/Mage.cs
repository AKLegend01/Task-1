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
            int 
        }

    }
}
