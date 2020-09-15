using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{

    class Map
    {
        private char[,] TileArray;
        private Hero H = new Hero();
        private int[] Enemys;
        private int MapWidth, MapHeight;
        private Random r = new Random();

        public Map(int minW, int maxW, int minH, int maxH)
        {
            int Width = r.Next(minW, maxW);
            int Height = r.Next(minH, minW);

            TileArray = new char[Width + 2, Height + 2];

            

        }  //  Question 3.2 - Constructor



        public void UpdateVision()
        {         
            
        }


        private Tile Create(Tile.TileType type)
        {

        }


    }

    
}
