using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    //Q2.1
    abstract class Tile
    {  
        //Protected member variables
        protected int X;
        protected int Y;
        protected char Symbol;
        protected TileType TypeOfTile;

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            Barrier,
            Empty
        }

        public Tile(int x, int y,TileType tileType, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            TypeOfTile = tileType;
        }

        public int getX
        { 
            get { return X; }
            set { X = value; }
        }
       
        public int getY 
        { 
            set { Y = value; } 
            get { return Y; }
        }
        
        public char getSymbol 
        { 
            set { Symbol = value; } 
            get { return Symbol; } 
        }

        public TileType GetTileType
        {
            set { TypeOfTile = value; }
            get { return TypeOfTile; }

        }  
    }
}
