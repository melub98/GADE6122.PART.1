using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.PART._1
{

    class Map
    {
        //private member variables and their public accessors
        private Tile[,] MapArray;
        private Hero LugaLad;// variable for player character
        private Enemy[] Enemies;
        private int Width;
        private int Height;
        private Random Mrandom = new Random();
        

        public int Mapwidth { set { Width = value; } get { return Width; } }
        public int Mapheight { set { Height = value; } get { return Height; } }

        public Tile[,] TileMapArray { set { MapArray = value; } get { return MapArray; } }
        public Hero Hero0 { set { LugaLad = value; } get { return LugaLad; } }
        public Enemy[] Enemies0 { set { Enemies = value; } get { return Enemies; } }
        public Map(int MinWidth, int MaxWidth, int MinHeight, int MaxHeight, int NoOfEnemies)
        {
            Width = Mrandom.Next(MinWidth, MaxWidth);// random number for map width
            Height = Mrandom.Next(MinHeight, MaxHeight);// randomized number for map height
            MapArray = new Tile[Width, Height];//creating of 2d array with values of map wdth aand height
            Enemies = new Enemy[NoOfEnemies];//enemy array based on number of enemies

            //constructor calls Create() to create the Hero, and loops through the enemy’s array calling Create() to create each enemy and puts them in the Tile map
            LugaLad = (Hero)Create(Tile.TileType.Hero);
            MapArray[Hero0.GetY, Hero0.GetX] = LugaLad;
            Enemies0 = new Enemy[NoOfEnemies];
            for (int i = 0; i < Enemies.Length; i++)
            {
                Enemies[i] = (Enemy)Create(Tile.TileType.Enemy);

                MapArray[Enemies[i].GetY, Enemies[i].GetX] = Enemies[i];
            }
        }

        private Tile Create(Tile.TileType type)// creates objects and also places them on the map
        {
            switch (type)
            {
                case Tile.TileType.Hero:
                    return new Hero(Mrandom.Next(1, Height - 1), Mrandom.Next(1, Width - 1), 40, 100, 'H');
                case Tile.TileType.Enemy:
                    int x, y;
                    x = Mrandom.Next(1, Width - 1);
                    y = Mrandom.Next(1, Height - 1);
                    while (MapArray[x, y] != null)
                    {
                        x = Mrandom.Next(1, Width - 1);
                        y = Mrandom.Next(1, Height - 1);
                    }
                    return new Mage(x, y, 5, 5);
                case Tile.TileType.Gold:
                    int X, Y;
                    X = Mrandom.Next(1, 5);
                    Y = Mrandom.Next(1, 5);
                    while (MapArray[X, Y] != null)
                    {
                        X = Mrandom.Next(1, 5);
                        Y = Mrandom.Next(1, 5);
                    }

                    return new Gold(X,Y, '$');
            }
            return null;
        }

        

        public void UpdateVision()//updates the vision array for each character
        {
            foreach (Enemy E in Enemies)
            {
                E.Vision[0] = MapArray[E.GetX, E.GetY - 1];
                E.Vision[1] = MapArray[E.GetX, E.GetY + 1];
                E.Vision[2] = MapArray[E.GetX + 1, E.GetY];
                E.Vision[3] = MapArray[E.GetX - 1, E.GetY];
            }
            LugaLad.Vision[0] = MapArray[LugaLad.GetX, LugaLad.GetY - 1];
            LugaLad.Vision[1] = MapArray[LugaLad.GetX, LugaLad.GetY + 1];
            LugaLad.Vision[2] = MapArray[LugaLad.GetX + 1, LugaLad.GetY];
            LugaLad.Vision[3] = MapArray[LugaLad.GetX - 1, LugaLad.GetY];
        }

        public void UpdateCharacterVision(Character character)//used by UpdateVision() for updating the vision array for each character
        {
            Console.WriteLine(character.GetY - 1);
            Console.WriteLine(character.GetX - 1);
            Console.WriteLine(character.GetY + 1);
            Console.WriteLine(character.GetX + 1);

            character.Vision = new Tile[4]{MapArray[character.GetY-1, character.GetX],
                MapArray[character.GetY +1, character.GetX], MapArray[character.GetY, character.GetX - 1],
                MapArray[character.GetY, character.GetX+1] };
        }

        public void PopulateBorders()
        {
            for (int i = 0; i < Mapwidth; i++)
            {
                TileMapArray[i, 0] = new Tile.Obstacle(i, 0);
            }

            for (int j = 0; j < Mapwidth; j++)
            {
                TileMapArray[j, Mapheight - 1] = new Tile.Obstacle(j, Mapheight);
            }

            for (int l = 0; l < Mapheight; l++)
            {
                TileMapArray[0, l] = new Tile.Obstacle(0, l);
            }

            for (int n = 0; n < Mapheight; n++)
            {
                TileMapArray[Mapwidth - 1, n] = new Tile.Obstacle(Mapwidth, n);
            }
        }
        //populates empty tiles
        public void PopulateEmptyTiles()
        {
            for (int i = 0; i < Mapwidth; i++)
            {
                for (int j = 0; j < Mapheight; j++)
                {
                    TileMapArray[i, j] = new Tile.EmptyTile(i, j);
                }
            }

            PopulateBorders();
            PopulateEmptyTiles();
        }

    }
}
