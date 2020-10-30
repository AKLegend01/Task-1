using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Program
    {
        GameEngine Game = new GameEngine();
        public void DisplayMap()
        {
                    
            string MapLine = "";

            for (int x = 0; x < Game.PlayerMap.MapWidth1; x++)
            {
                for (int y = 0; y < Game.PlayerMap.MapHeight1; y++)
                {
                    if (Game.PlayerMap.TileArray[x,y].tileType == Tile.TileType.Empty)
                    {
                        MapLine += ".";
                    }
                    if (Game.PlayerMap.TileArray[x, y].tileType == Tile.TileType.Goblin)
                    {
                        MapLine += "G";
                    }
                    if (Game.PlayerMap.TileArray[x, y].tileType == Tile.TileType.Mage)
                    {
                        MapLine += "M";
                    }
                    if (Game.PlayerMap.TileArray[x, y].tileType == Tile.TileType.Gold)
                    {
                        MapLine += "$";
                    }
                    if (Game.PlayerMap.TileArray[x, y].tileType == Tile.TileType.Hero)
                    {
                        MapLine += "H";
                    }
                    if (Game.PlayerMap.TileArray[x, y].tileType == Tile.TileType.obsticle)
                    {
                        MapLine += "X";
                    }

                }

                MapLine += "\n";

            }

            Console.WriteLine(MapLine);
            Console.WriteLine(Game.Player.ToString());
        }


        public void Main(string[] args)
        {
            string MoveChoice = "";

            while (Game.Player.HP > 0)
            {
                DisplayMap();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please select your movement (1-4)");
                MoveChoice += "1 : UP" + "\n" + "2 : Down" + "\n" + "3 : Left" + "\n" + "4 : Right";
                Console.WriteLine(MoveChoice);
                int Move = Convert.ToInt32(Console.ReadLine());

                switch (Move)
                {
                    case 1: Game.MovePlayer(Character.Movement.Up);
                        break;
                    case 2:
                        Game.MovePlayer(Character.Movement.Down);
                        break;
                    case 3:
                        Game.MovePlayer(Character.Movement.Left);
                        break;
                    case 4:
                        Game.MovePlayer(Character.Movement.Right);
                        break;
                    default: Game.MovePlayer(Character.Movement.None);
                        break;
                }


                Console.WriteLine("Do you wish to attempt an attack on an enemy (y/n?)");
                string ans = Console.ReadLine();
                while (ans == "y" || ans == "Y")
                {
                    Console.WriteLine("Select an enemy to Attack");
                    for (int i = 0; i != Game.PlayerMap.Enemys1.Length; i++)
                    {
                        Console.WriteLine("1 : Enemy at x" + Game.PlayerMap.Enemys1[i].X + "and y" + Game.PlayerMap.Enemys1[i].Y);
                    }

                    int who = Convert.ToInt32(Console.ReadLine());

                    if (Game.Player.CheckRange(Game.PlayerMap.Enemys1[who - 1]) == true)
                    {
                        Game.Player.Attack(Game.PlayerMap.Enemys1[who - 1]);
                        Console.WriteLine("successfull attack");
                        Game.EnemyAttack();
                        ans = "n";
                    }
                    else
                    {
                        Console.WriteLine("enemy is not in range. Do you wish to attempt an attack on an enemy (y/n?)");
                        ans = Console.ReadLine();
                    }


                }

                for (int i = 0; i < Game.PlayerMap.Enemys1.Length; i++)
                {
                    if (Game.PlayerMap.Enemys1[i].HP < 1)
                    {
                        Game.PlayerMap.TileArray[Game.PlayerMap.Enemys1[i].X, Game.PlayerMap.Enemys1[i].Y] = new EmptyTile(Game.PlayerMap.Enemys1[i].X, Game.PlayerMap.Enemys1[i].Y);
                    }
                }
            }

        }
    }
}
