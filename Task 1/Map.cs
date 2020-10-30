using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{

    class Map
    {
        public Tile[,] TileArray;
        private Hero H;
        private Enemy[] Enemys;
        private int MapWidth, MapHeight;
        private Random r = new Random();
        private Item[] Items;
        int count = 0;

        public int MapWidth1 { get => MapWidth; set => MapWidth = value; }
        public int MapHeight1 { get => MapHeight; set => MapHeight = value; }
        internal Item[] Items1 { get => Items; set => Items = value; }
        internal Hero H1 { get => H; set => H = value; }
        internal Enemy[] Enemys1 { get => Enemys; set => Enemys = value; }

        public Map(int minW, int maxW, int minH, int maxH, int numEnemies, int goldDrop)
        {
            MapWidth = r.Next(minW, maxW + 1);
            MapHeight = r.Next(minH, maxH + 1);

            this.TileArray = new Tile[MapWidth , MapHeight];
            this.Enemys1 = new Enemy[numEnemies];

            this.Items1 = new Item[goldDrop];
            

            for (int y = 0; y != MapHeight; y++)
            {
                for (int x = 0; x != MapWidth; x++)
                {
                    if (x == 0 || y == 0 || x == MapWidth || y == MapHeight) TileArray[x, y] = new Obstacle(x, y);
                    else TileArray[x, y] = new EmptyTile(x, y);
                }
            }

            //TODO: Create Blank map with obstacles on border and the rest of the tiles as empty


            Create(Tile.TileType.Hero);

            count = 0;
            int rand;
            while (count != numEnemies)
            {
                count++;
                rand = r.Next(1, 4);
                if (rand == 1) Create(Tile.TileType.Mage);
                else Create(Tile.TileType.Goblin);
            }

            count = 0;
            while (count != goldDrop)
            {
                count++;
                Create(Tile.TileType.Gold);
            }


        }  //  Question 3.2 - Constructor

        //private void InsertTileIntoMap(Tile tile)
        //{
        //    //insert into TileArray based on tile.X and tile.Y
        //    //TileArray

        //    throw new NotImplementedException();
        //}

        public void UpdateVision()
        {
            H1.TileVision[0] = TileArray[H1.X, H1.Y + 1];
            H1.TileVision[1] = TileArray[H1.X, H1.Y - 1];
            H1.TileVision[2] = TileArray[H1.X - 1, H1.Y];
            H1.TileVision[3] = TileArray[H1.X + 1, H1.Y];

            H1.TileVision[4] = TileArray[H1.X + 1, H1.Y + 1];
            H1.TileVision[5] = TileArray[H1.X + 1, H1.Y - 1];
            H1.TileVision[6] = TileArray[H1.X - 1, H1.Y + 1];
            H1.TileVision[7] = TileArray[H1.X - 1, H1.Y - 1];

            int count = 0;
            while (count != Enemys1.Length)
            {
                Enemys1[count].TileVision[0] = TileArray[H1.X, H1.Y + 1];
                Enemys1[count].TileVision[1] = TileArray[H1.X, H1.Y - 1];
                Enemys1[count].TileVision[2] = TileArray[H1.X - 1, H1.Y];
                Enemys1[count].TileVision[3] = TileArray[H1.X + 1, H1.Y];

                Enemys1[count].TileVision[4] = TileArray[H1.X + 1, H1.Y + 1];
                Enemys1[count].TileVision[5] = TileArray[H1.X + 1, H1.Y - 1];
                Enemys1[count].TileVision[6] = TileArray[H1.X - 1, H1.Y + 1];
                Enemys1[count].TileVision[7] = TileArray[H1.X - 1, H1.Y - 1];
                count++;
            }
        }


        private Tile Create(Tile.TileType type)
        {
            int PosX = r.Next(1, MapWidth + 1);
            int PosY = r.Next(1, MapHeight + 1);

            //while (TileArray[PosX,PosY].TileEnum != Tile.TileType.Empty)
            //{
            //    PosX = r.Next(1, MapWidth + 1);
            //    PosY = r.Next(1, MapHeight + 1);
            //}

            while (true)                                          
            {
                if (TileArray[PosX, PosY] != null)
                {
                    PosX = r.Next(1, MapWidth + 1);
                    PosY = r.Next(1, MapHeight + 1);
                }
                else
                {
                    break;
                }
            }


            switch (type)  // "type" ---> Enter
            {
                case Tile.TileType.Hero:
                    H1 = new Hero(PosX, PosY, 100);
                    TileArray[H1.X, H1.Y] = H1;
                    return H1;
                case Tile.TileType.Mage:
                    Enemys1[count] = new Mage(PosX, PosY);
                    return Enemys1[count];
                case Tile.TileType.Goblin:
                    Enemys1[count] = new Goblin(PosX, PosY);
                    break;
                case Tile.TileType.Gold:
                    Items1[count] = new Gold(PosX,PosY);
                    return Items1[count];
                case Tile.TileType.Weapon:
                    throw new NotImplementedException();
                case Tile.TileType.Empty:
                    throw new NotImplementedException();

            }

            return null;

            //InsertTileIntoMap(newTile);


            //if (type == Tile.TileType.Hero) return new Hero(PosX, PosY, hp);
            //else return new Goblin(PosX, PosY);

        }


        public Item GetItemPosision(int x, int y)
        {
            for (int i = 0; i < Items1.Length; i++)
            {
                if (Items1[i].X == x && Items1[i].Y == y)
                {
                    Item thisGold;
                    thisGold = Items1[i];
                    Items1[i] = null;
                    return thisGold;
                }
               
            }
            return null;
        }





        //private Tile GetRandomEmptyTile()
        //{
        //    //Get all available empty tiles as array; 

        //    Tile[] emptyTiles = GetAllEmptyTiles();

        //    // get renadom tile from emptyTiles

        //    int selectedTileIndex = r.Next(0, emptyTiles.Length - 1);

        //    Tile selectedTile = emptyTiles[selectedTileIndex];

        //    return selectedTile;
        //}



        //private Tile[] GetAllEmptyTiles()
        //{
        //    throw new NotImplementedException();

        //}
    }


}
