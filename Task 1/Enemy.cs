using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        public Enemy(int x, int y, int Damage, int hp) : base (x, y)
        {
            hP = hp;
            damage = Damage;
            MaxHP = hp;
            
        }  // Question 2.4 - Constructor

        public override string ToString()
        {
            string Output = "Enemy at " + Convert.ToString(x) + ", " + Convert.ToString(y) + " (" + Convert.ToString(Damage) + ")";
            return Output;
        }  // Question 2.4 - ToString

    }
}
