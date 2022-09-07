using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.PART._1
{
    internal class GameEngine
    {
        private Map map;//private map variable
        public Map Map { set { map = value; } get { return map; } }//public accesor for map

        public GameEngine(int MinWidth, int MaxWidth, int MinHeight, int MaxHeight, int NoOfEnemies)
        {
            map = new Map(MinWidth, MaxWidth, MinHeight, MaxHeight, NoOfEnemies);
        }

        public bool MovePlayer(Character.Movement direction)//This is interfaced with via the Form’s/keyboard’s buttons.
        {
            if (direction == Character.Movement.Left)
            {
                if (map.hero.GetX - 1 != 0 && map.hero.Vision[2] == null)
                {
                    map.TileMapArray[map.hero.GetY, map.hero.GetX] = null;
                    map.hero.Move(Character.Movement.Left);
                    map.TileMapArray[map.hero.GetY, map.hero.GetX] = map.hero;
                    return true;
                }
            }
            else if (direction == Character.Movement.Right)
            {
                if (map.hero.GetX + 2 != map.height && map.hero.Vision[3] == null)
                {
                    map.TileMapArray[map.hero.GetY, map.hero.GetX] = null;
                    map.hero.Move(Character.Movement.Right);
                    map.TileMapArray[map.hero.GetY, map.hero.GetX] = map.hero;
                    return true;
                }
            }
            else if (direction == Character.Movement.Up)
            {
                if (map.hero.GetY - 1 != 0 && map.hero.Vision[0] == null)
                {
                    map.TileMapArray[map.hero.GetY, map.hero.GetX] = null;
                    map.hero.Move(Character.Movement.Up);
                    map.TileMapArray[map.hero.GetY, map.hero.GetX] = map.hero;
                    return true;
                }
            }
            else
            {
                if (map.hero.GetY + 2 != map.width && map.hero.Vision[1] == null)
                {
                    map.TileMapArray[map.hero.GetY, map.hero.GetX] = null;
                    map.hero.Move(Character.Movement.Down);
                    map.TileMapArray[map.hero.GetY, map.hero.GetX] = map.hero;
                    return true;
                }
            }
            return false;
        }
    }
}
