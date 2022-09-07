using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.PART._1
{
     abstract class Tile
        {
            //protected member variables for X and Y coordinates
            protected int X;
            protected int Y;

            //public accessors for the member variables
            public int GetX { set { X = value; } get { return X; } }
            public int GetY { set { Y = value; } get { return Y; } }

            public enum TileType { Hero, Enemy, Gold, Weapon }//the public enum which defines type of tile


            protected Tile(int ValX, int ValY)//constructor that recieves and sets values
            {
                X = ValX;
                Y = ValY;
            }



            protected char Symbol;
            public char GetSymbol { set { Symbol = value; } get { return Symbol; } }



            public class Obstacle : Tile //Obstace class for obstacles on the map 
            {

                public Obstacle(int X, int Y) : base(X, Y)
                {

                }
            }
            public class EmptyTile : Tile// EmptyTile class there just to donate an empty tile
            {
                public EmptyTile(int X, int Y) : base(X, Y)
                {

                }
            }
        public TileType TileType0 { get; set; }






    }

    }

