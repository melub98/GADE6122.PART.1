using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1    //Q2.1
{ 
    class Obstacle : Tile
    {
        public Obstacle(int x,int y, TileType tileType) : base(x, y, tileType, 'X')
        {
            
        }
    }
}
