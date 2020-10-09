using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        public Enemy(int x, int y, int Damage, int hp, char who) : base (hp, Damage, hp, x, y, who)
        {
           
            
        }  // Question 2.4 - Constructor

        public override string ToString()
        {
            string Output = nameof(Enemy) + Convert.ToString(x) + ", " + Convert.ToString(y) + " (" + Convert.ToString(Damage) + ")";
            return Output;
        }  // Question 2.4 - ToString

    }
}
