using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using static Task_1.Tile;

namespace Task_1
{
    class Map
    {
        private Tile[,] map;
        public Tile[,] GetMaps
        {
            get { return map; }
            set { map = value; }
        }

        private Hero Player;
        public Hero GetPlayer
        {
            get { return Player; }
            set { Player = value; }
        }

        private Enemy[]  enemies;

        public Enemy[] GetEnemies
        {
            get { return enemies; }
            set { enemies = value; }
        }

        public Item [] items;

        public  Item [] GetItems
        {
            get { return items; }
            set { items = value; }
        }

        private int mapwidth;

        public int getmapwidth
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        private int mapheight;

        public int getmapheight
        {
            get { return mapheight; }
            set { mapheight = value; }
        }
        private Random rnd = new Random();

        public Map(int min_width, int max_width, int min_height, int max_height, int num_enemies, int num_items)
        {
            mapwidth = rnd.Next(min_width, max_width+1);            //map width
            mapheight = rnd.Next(min_height, max_height+1);         //map height
            map = new Tile[mapwidth, mapheight];                    //map (width and height)

            enemies = new Enemy[num_enemies];                       //enemies
            items = new Item[num_items+4];                            //items


            generate_map();                                         //creating empty tiles and border

            Player = (Hero)Create(TileType.Hero);                   //creating hero (title type = hero)
            map[Player.getX, Player.getY] = Player;                 //adding player to map

            for (int i = 0; i < enemies.Length; i++)               
            {
                enemies[i] = (Enemy)Create(TileType.Enemy);         //create multiple enemies
                map[enemies[i].getX, enemies[i].getY] = enemies[i]; //add multiple enemies to map
            }   

            for (int z = 0; z < items.Length; z++)                  
            {
                items[z] = (Item)Create(TileType.Gold);      
                map[items[z].getX, items[z].getY] = items[z];       //add items(gold) to map
            }
            UpdateVision();
        }

        
        public void UpdateGame()
        {
            generate_map();
            
            map[Player.getX, Player.getY] = Player;

            RemoveDead();

            for (int i = 0; i < enemies.Length; i++)
            {
                map[enemies[i].getX, enemies[i].getY] = enemies[i];
            }

            AddGold();
            for (int i = 0; i < items.Length; i++)
            {
                map[items[i].getX, items[i].getY] = items[i];
            }
            
            UpdateVision();
        }
         void generate_map()                                    //creates the empty tiles
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    map[x, y] = new EmptyTile(x, y, TileType.Empty);
                }
            }

            for (int y = 0; y < map.GetLength(1); y++)          //Creates borders
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if ((y == 0 || y == map.GetLength(1) - 1) || x == 0 || (x == map.GetLength(0) - 1))
                    {
                        map[x, y] = new Obstacle(x, y, TileType.Barrier);
                    }
                }
            }
        }

        private void AddGold()
        {
            for (int i = 0; i < items.Length; i++)
            {
                if(map[Player.getX, Player.getY] == map[items[i].getX, items[i].getY])
                {
                    Player.Pickup(GetItemAtPosition(Player.getX, Player.getY));
                }
            }

        }


        public Item GetItemAtPosition(int x, int y)
        {
            Item output = null;
            for (int i = 0; i < items.Length; i++)
            {
                if(x == items[i].getX && y == items[i].getY && items[i].GetTileType == TileType.Gold)
                {
                    output = items[i];
                    items[i] = null;
                    items = items.Where(i => i != null).ToArray();
                }
            }
            return output;
        }
        private Tile Create(TileType tileType,int x = 0, int y = 0)
        {

            switch (tileType)
            {
                case TileType.Hero:
                    int HeroX = rnd.Next(0, mapwidth);
                    int HeroY = rnd.Next(0, mapheight);
                    while( map[HeroX,HeroY].GetType() != typeof(EmptyTile))
                    {
                         HeroX = rnd.Next(0, mapwidth);
                         HeroY = rnd.Next(0, mapheight);
                    }
                    return new Hero(HeroX, HeroY, tileType);                    

                case TileType.Gold:
                    int ItemX = rnd.Next(0, mapwidth);
                    int ItemY = rnd.Next(0, mapheight);

                    while (map[ItemX, ItemY].GetType() != typeof(EmptyTile))
                    {
                        ItemX = rnd.Next(0, mapwidth);
                        ItemY = rnd.Next(0, mapheight);
                    }
                    return new Gold(ItemX, ItemY, tileType);

                case TileType.Enemy:
                    int determine_enemy = rnd.Next(0, 3);
                    int EnemyX = rnd.Next(0, mapwidth);
                    int EnemyY = rnd.Next(0, mapheight);

                    while (map[EnemyX, EnemyY].GetType() != typeof(EmptyTile))
                    {
                        EnemyX = rnd.Next(0, mapwidth);
                        EnemyY = rnd.Next(0, mapheight);
                    }
                    if (determine_enemy == 0)
                    {
                        return new SwampCreature(EnemyX, EnemyY, tileType);
                    }
                    else if (determine_enemy == 1)
                    {
                        return new Mage(EnemyX, EnemyY, tileType);
                    }

                default:
                    return null;
            }
        }

        public void UpdateVision()
        {
            foreach(Enemy E in enemies)
            {
                E.Vision[0] = map[E.getX, E.getY - 1];
                E.Vision[1] = map[E.getX, E.getY + 1];
                E.Vision[2] = map[E.getX + 1, E.getY];
                E.Vision[3] = map[E.getX - 1, E.getY];
            }
            Player.Vision[0] = map[Player.getX, Player.getY - 1];
            Player.Vision[1] = map[Player.getX, Player.getY + 1];
            Player.Vision[2] = map[Player.getX + 1, Player.getY];
            Player.Vision[3] = map[Player.getX - 1, Player.getY];
        }

        public void RemoveDead()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i].isdead())
                {
                    enemies[i] = null;
                    enemies = enemies.Where(i => i != null).ToArray();
                }
            }
        }
        public string DrawMap()
        {
            string output = "";
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    output += map[x, y].getSymbol; 
                }
                output += '\n';
            }
            return output;
        }   
    }
}
