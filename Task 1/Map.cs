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

        public int MapWidth1 { get => MapWidth; set => MapWidth = value; }
        public int MapHeight1 { get => MapHeight; set => MapHeight = value; }


        public Map(int minW, int maxW, int minH, int maxH, int numEnemies, int goldDrop)
        {
            MapWidth = r.Next(minW, maxW + 1);
            MapHeight = r.Next(minH, maxH + 1);

            this.TileArray = new Tile[MapWidth , MapHeight];
            this.Enemys = new Enemy[numEnemies];

            this.Items = new Item[goldDrop];
            int count = 0;


            //TODO: Create Blank map with obstacles on border and the rest of the tiles as empty


            Create(Tile.TileType.Hero);

            count = 0;
            while (count != numEnemies)
            {
                count++;
                Create(Tile.TileType.Enemy);
            }

            count = 0;
            while (count != Items.Length)
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

            Tile newTile;
            int rand;

            switch (type)  // "type" ---> Enter
            {
                case Tile.TileType.Hero:
                    newTile = new Hero(PosX, PosY, 100);
                    break;
                case Tile.TileType.Enemy:
                    rand = r.Next(1, 4);
                    if (rand == 1) newTile = new Mage(PosX, PosY);
                    else newTile = new Goblin(PosX, PosY);
                    break;
                case Tile.TileType.Gold:
                    newTile = new Gold(PosX,PosY);
                    break;
                case Tile.TileType.Weapon:
                    throw new NotImplementedException();
                case Tile.TileType.Empty:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();

            }

            //InsertTileIntoMap(newTile);

            return newTile;

            //if (type == Tile.TileType.Hero) return new Hero(PosX, PosY, hp);
            //else return new Goblin(PosX, PosY);



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
