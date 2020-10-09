using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int minW, maxW, minH, maxH, EnemyNum;

            Console.WriteLine("Enter map minimum width :");
            minW = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter map maximum width :");
            maxW = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter map minimum height :");
            minH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter map maximum height :");
            maxH = Convert.ToInt32(Console.ReadLine());

            EnemyNum = minH + minW;


            Map Variable = new Map(minW, maxW, minH, maxH, EnemyNum);

            for (int i = 0; i < Variable.MapWidth1; i++)
            {
                for (int j = 0; j < Variable.MapHeight1; j++)
                {
                    if (i == 0 || j == 0 || i == Variable.MapWidth1 - 1 || j == Variable.MapHeight1 - 1) Variable.TileArray[i, j] 


                }


            }

        }
    }
}
