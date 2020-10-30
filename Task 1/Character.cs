using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Character : Tile
    {
        protected int maxHP;
        protected Tile[] tileVision = new Tile[8];
        protected int damage;   
        protected int hP;
        private int gold;

        //public int Damage { get; set;   ---> "prop" tab tab



        public int Damage { get => damage; set => damage = value; }
        public int HP { get => hP; set => hP = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public Tile[] TileVision { get => tileVision; set => tileVision = value; }
        protected int Gold { get => gold; set => gold = value; }

        public enum Movement { None, Up, Down, Left, Right };


        // Question 2.2 - variables declared 


        public Character(int x, int y, char Who) : base(x, y)
        {
           
        }  // Question 2.3 - Constructor for X and Y


        public virtual void Attack(Character Target)
        {
            Target.HP -= Damage;
        }  // Question 2.3 - attack method


        public bool IsDead()
        {
            if (HP <= 0) return true;
            else return false;
        }  // Question 2.3 - dead method

        public virtual bool CheckRange(Character Target)
        {
            int Distance = DistanceTo(Target);
            if (Distance == 1) return true;
            else return false;
        }  //Question 2.3 - check for valid attack range

        private int DistanceTo(Character target)
        {
            int DistanceX = (X - target.X);
            int DistanceY = (Y - target.Y);

            if (DistanceX < 0) X *= -1;
            if (DistanceY < 0) X *= -1;

            int Total = DistanceX + DistanceY;
            return Total;
        }  // Question 2.3 - check distance between target and attacker

        public void Move(Movement Move)
        {
            switch (Move)
            {
                case Movement.Up: Y += 1;
                    break;
                case Movement.Down: Y -= 1;
                    break;
                case Movement.Right: X += 1;
                    break;
                case Movement.Left: X -= 1;
                    break;
                case Movement.None: X += 0;
                    break;
            }
        }  //  Question 2.3 - Move Character


        public abstract Movement ReturnMove(Movement Move = 0);


        public abstract override string ToString();    // Question 2.3 - ToString Override

        public void Pickup(Item i)
        {
            Random Amount = new Random();
            if (i.tileType == Tile.TileType.Gold) Gold += Amount.Next(1,6);          
        }
    }
}
