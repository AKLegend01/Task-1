using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class GameEngine
    {
        private Map playerMap;
        private Hero player;

        public Map PlayerMap { get => PlayerMap; set => PlayerMap = value; }

        public GameEngine()
        {
            Map MAP = new Map(10, 20, 10, 20, 20);
            
        }

        

        public bool MovePlayer(Character.Movement direction)
        {
            bool value = false;
            switch (direction)
            {
                case Character.Movement.Up :
                    if (player.TileVision[1].tileType == Tile.TileType.Empty)
                    {
                        player.Move(Character.Movement.Up);
                        PlayerMap.UpdateVision();
                        value = true;                       
                    }
                    break;



                case Character.Movement.Down:
                    if (player.TileVision[2].tileType == Tile.TileType.Empty)
                    {
                        player.Move(Character.Movement.Down);
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    break;

                 

                case Character.Movement.Left:
                    if (player.TileVision[3].tileType == Tile.TileType.Empty)
                    {
                        player.Move(Character.Movement.Left);
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    break;



                case Character.Movement.Right:
                    if (player.TileVision[4].tileType == Tile.TileType.Empty)
                    {
                        player.Move(Character.Movement.Right);
                        PlayerMap.UpdateVision();
                        value = true;
                    }
                    break;

            }           
 
            if (direction == Character.Movement.None) return false;

            if (value == true) return true;
            else return false;

        }


    }
}
