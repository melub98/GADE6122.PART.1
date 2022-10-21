using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    abstract class Item : Tile
    {
        public Item(int x, int y, TileType tileType, char symbol) : base(x, y, tileType, symbol)
        {

        }

        public abstract override string ToString();
    }
}
