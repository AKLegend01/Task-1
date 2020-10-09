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
           
        }

        

        public bool MovePlayer(Character.Movement direction)
        {

            switch (direction)
            {
                case Character.Movement.Up :
                    if (player.TileVision[1].TileEnum == Tile.TileType.Empty)
                    {
                        player.Move(Character.Movement.Up);
                        PlayerMap.UpdateVision();
                        return true;
                    }
                    else return false;



                case Character.Movement.Down:
                    if (player.TileVision[2].TileEnum == Tile.TileType.Empty)
                    {
                        player.Move(Character.Movement.Down);
                        PlayerMap.UpdateVision();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                 

                case Character.Movement.Left:
                    if (player.TileVision[3].TileEnum == Tile.TileType.Empty)
                    {
                        player.Move(Character.Movement.Left);
                        PlayerMap.UpdateVision();
                        return true;
                    }
                    else
                    {
                        return false;
                    }



                case Character.Movement.Right:
                    if (player.TileVision[4].TileEnum == Tile.TileType.Empty)
                    {
                        player.Move(Character.Movement.Right);
                        PlayerMap.UpdateVision();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

            }           
 
            if (direction == Character.Movement.None) return false;


        }


    }
}
