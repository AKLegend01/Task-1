﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class GameEngine
    {
        private Map playerMap;
        private Hero player;

        public Map PlayerMap { get => PlayerMap; set => PlayerMap = value; }
        public Hero Player { get => player; set => player = value; }

        public GameEngine()
        {
            Map MAP = new Map(10, 20, 10, 20, 20, 10);
            
        }

        

        public bool MovePlayer(Character.Movement direction)
        {
            bool value = false;
            switch (direction)
            {
                case Character.Movement.Up :
                    if (Player.TileVision[1].tileType == Tile.TileType.Empty)
                    {
                        Player.Move(Character.Movement.Up);
                        PlayerMap.TileArray[player.X, player.Y] = player;
                        PlayerMap.TileArray[player.X, player.Y + 1] = player;
                        PlayerMap.UpdateVision();
                        value = true;                       
                    }
                    if (Player.TileVision[1].tileType == Tile.TileType.Empty)
                    {
                        for (int i = 0; i < playerMap.Items1.Length; i++)
                        {
                            if (playerMap.Items1[i].X == player.X && playerMap.Items1[i].Y == player.Y) player.Pickup(playerMap.Items1[1]);
                        } 

                        Player.Move(Character.Movement.Up);
                        PlayerMap.TileArray[player.X, player.Y] = player;
                        PlayerMap.TileArray[player.X, player.Y + 1] = player;
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    break;



                case Character.Movement.Down:
                    if (Player.TileVision[2].tileType == Tile.TileType.Empty)
                    {
                        Player.Move(Character.Movement.Down);
                        PlayerMap.TileArray[player.X, player.Y] = player;
                        PlayerMap.TileArray[player.X, player.Y - 1] = player;
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    if (Player.TileVision[1].tileType == Tile.TileType.Empty)
                    {
                        for (int i = 0; i < playerMap.Items1.Length; i++)
                        {
                            if (playerMap.Items1[i].X == player.X && playerMap.Items1[i].Y == player.Y) player.Pickup(playerMap.Items1[1]);
                        }

                        Player.Move(Character.Movement.Up);
                        PlayerMap.TileArray[player.X, player.Y] = player;
                        PlayerMap.TileArray[player.X, player.Y - 1] = player;
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    break;

                 

                case Character.Movement.Left:
                    if (Player.TileVision[3].tileType == Tile.TileType.Empty)
                    {
                        Player.Move(Character.Movement.Left);
                        PlayerMap.TileArray[player.X, player.Y] = player;
                        PlayerMap.TileArray[player.X - 1, player.Y] = player;
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    if (Player.TileVision[1].tileType == Tile.TileType.Empty)
                    {
                        for (int i = 0; i < playerMap.Items1.Length; i++)
                        {
                            if (playerMap.Items1[i].X == player.X && playerMap.Items1[i].Y == player.Y) player.Pickup(playerMap.Items1[1]);
                        }

                        Player.Move(Character.Movement.Up);
                        PlayerMap.TileArray[player.X, player.Y] = player;
                        PlayerMap.TileArray[player.X - 1, player.Y] = player;
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    break;



                case Character.Movement.Right:
                    if (Player.TileVision[4].tileType == Tile.TileType.Empty)
                    {
                        Player.Move(Character.Movement.Right);
                        PlayerMap.TileArray[player.X, player.Y] = player;
                        PlayerMap.TileArray[player.X + 1, player.Y] = player;
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    if (Player.TileVision[1].tileType == Tile.TileType.Empty)
                    {
                        for (int i = 0; i < playerMap.Items1.Length; i++)
                        {
                            if (playerMap.Items1[i].X == player.X && playerMap.Items1[i].Y == player.Y) player.Pickup(playerMap.Items1[1]);
                        }

                        Player.Move(Character.Movement.Up);
                        PlayerMap.TileArray[player.X, player.Y] = player;
                        PlayerMap.TileArray[player.X + 1, player.Y] = player;
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    break;

            }           
 
            if (direction == Character.Movement.None) return false;

            if (value == true) return true;
            else return false;

        }


        public void EnemyAttack()
        {
            for (int i = 0; i < PlayerMap.Enemys1.Length; i++)
            {
                if (PlayerMap.Enemys1[i].tileType == Tile.TileType.Goblin)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (playerMap.Enemys1[i].TileVision[k].tileType == Tile.TileType.Hero) PlayerMap.Enemys1[i].Attack(player);
                    }
                }


                if (PlayerMap.Enemys1[i].tileType == Tile.TileType.Mage)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (playerMap.Enemys1[i].TileVision[k].tileType == Tile.TileType.Hero) PlayerMap.Enemys1[i].Attack(player);

                        if (PlayerMap.Enemys1[i].TileVision[k].tileType == Tile.TileType.Goblin)
                        {
                            for (int j = 0; j < playerMap.Enemys1.Length; j++)
                            {
                                if (PlayerMap.Enemys1[j].X == playerMap.Enemys1[i].TileVision[k].X && PlayerMap.Enemys1[j].Y == playerMap.Enemys1[i].TileVision[k].Y)
                                {
                                    playerMap.Enemys1[i].Attack(playerMap.Enemys1[j]);
                                }
                            }
                            
                        }
                    }

                    
                }


            }
        }


    }
}
