using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    //Q2.1
    class EmptyTile : Tile          //exists to denote an empty tile
    {
        public EmptyTile(int x, int y, TileType tile_type) : base(x, y, tile_type,'.')
        {

        }
    }
}
