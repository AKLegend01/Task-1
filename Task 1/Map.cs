using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{

    class Map
    {
        public Tile[,] TileArray;
        private Tile tile;
        private Hero H;
        private Enemy[] Enemys;
        private int MapWidth, MapHeight;
        private Random r = new Random();

        public int MapWidth1 { get => MapWidth; set => MapWidth = value; }
        public int MapHeight1 { get => MapHeight; set => MapHeight = value; }


        public Map(int minW, int maxW, int minH, int maxH, int numE)
        {
            int Width = r.Next(minW, maxW);
            int Height = r.Next(minH, maxH);

            Tile[,] Map = new Tile[Width + 2, Height + 2];
            Enemys = new Enemy[numE];

            Create(Tile.TileType.Hero);

            int count = 0;
            while (count != numE)
            {
                count++;
                Create(Tile.TileType.Enemy);
            }

        }  //  Question 3.2 - Constructor

        

        public void UpdateVision()
        {
            H.TileVision[1] = TileArray[H.X, H.Y + 1];
            H.TileVision[2] = TileArray[H.X, H.Y - 1];
            H.TileVision[3] = TileArray[H.X - 1, H.Y];
            H.TileVision[4] = TileArray[H.X + 1, H.Y];

            int count = 0;
            while (count != Enemys.Length)
            {
                Enemys[count].TileVision[1] = TileArray[H.X, H.Y + 1];
                Enemys[count].TileVision[2] = TileArray[H.X, H.Y - 1];
                Enemys[count].TileVision[3] = TileArray[H.X - 1, H.Y];
                Enemys[count].TileVision[4] = TileArray[H.X + 1, H.Y];
                count++;
            }
        }


        private Tile Create(Tile.TileType type)
        {
            int PosX = r.Next(1, MapWidth + 1);
            int PosY = r.Next(1, MapHeight + 1);
            tile = TileArray[PosX, PosY];

            while (tile.TileEnum != Tile.TileType.Empty)                                               //while (TileArray[PosX,PosY].TileEnum != Tile.TileType.Empty)
            {                                                                                          //{
                PosX = r.Next(1, MapWidth + 1);                                                        //    PosX = r.Next(1, MapWidth + 1);
                PosY = r.Next(1, MapHeight + 1);                                                       //    PosY = r.Next(1, MapHeight + 1);
                tile = TileArray[PosX, PosY];                                                          //}
            }

            


            switch (type)                                                                             //if (type == Tile.TileType.Hero) return new Hero(PosX, PosY, hp);
            {                                                                                          //else return new Goblin(PosX, PosY);
            
                case Tile.TileType.Hero:
                    return new Hero(PosX, PosY, 100);

                case Tile.TileType.Enemy:
                    return new Goblin(PosX,PosY);


                case Tile.TileType.Gold:

                    break;

                case Tile.TileType.Weapon:

                    break;

                case


                    break;

            }
            
        }


    }

    
}
