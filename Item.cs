﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.PART._1
{
    abstract class Item : Tile
    {
        public Item(int X, int Y,  char symbol) : base(X, Y)
        {

        }

        public abstract override string ToString();
    }
}
