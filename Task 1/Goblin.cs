using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base (x, y, 1, 10)
        {

        }  //  Question 2.5 - recive X and Y and pass on



        public override Movement ReturnMove(Movement Move)
        {
            bool found = false;
            while (found == false)
            {
                int move = r.Next(1, 5);
                switch (move)
                {
                    case 1: 
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }

                return Move; 
            }
        }
        

    }
}
