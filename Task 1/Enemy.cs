using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();
        public Enemy(int HP, int maxHp, int Damage) : base (HP, maxHp, Damage)
        {

        }
        public Enemy(int x, int y) : base (x, y)
        {

        }  // Question 2.4 - Constructor

        public override string ToString()
        {
            string Output = "Enemy at " + Convert.ToString(x) + ", " + Convert.ToString(y) + " (" + Convert.ToString(Damage) + ")";
            return Output;
        }  // Question 2.4 - 

    }
}
