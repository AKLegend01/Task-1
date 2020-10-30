using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Hero : Character
    {
        public Hero(int X, int Y, int Hp) : base(X, Y, 'H')
        {
            this.HP = Hp;
            this.MaxHP = Hp;
            this.Damage = 2;
        }  //  Question 2.6 

        public override string ToString()
        {
            string Output = "Player Stats : " + "\n";
            Output += "HP : " + hP + "/" + maxHP + "\n";
            Output += "Damage : 2" + "\n";
            Output += "[" + X + Y + "]" + "\n";
            Output += "gold : 2" + Gold;


            return Output;
        }  //  Question 2.6 

        public override Movement ReturnMove(Movement Move)
        {
            //Get Target tile

            //get target tile based on x y

            //test target tile if empty

            var canMove = tileVision[Convert.ToInt32(Move)].tileType;
            if (canMove != TileType.Empty) return Move;
            else return Movement.None;
        }

    }
}
