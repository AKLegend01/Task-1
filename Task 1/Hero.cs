using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Hero : Character
    {
        public Hero(int X, int Y, int Hp) : base(X, Y)
        {
            MaxHP = Hp;
            hP = Hp;
            damage = 2;
        }  //  Question 2.6 

        public override string ToString()
        {
            string Output = "Player Stats : " + "\n";
            Output += "HP : " + hP + "/" + maxHP + "\n";
            Output += "Damage : 2" + "\n";
            Output += "[" + X + Y + "]";

            return Output;
        }  //  Question 2.6 


        public override Movement ReturnMove(Movement Move)
        {

        }

    }
}
