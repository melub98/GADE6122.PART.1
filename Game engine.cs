using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace GADE6122.PART._1
{
     class GameEngine
    {
        private Map map;//private map variable
        public Map Map { set { map = value; } get { return map; } }//public accesor for map

        public GameEngine(int MinWidth, int MaxWidth, int MinHeight, int MaxHeight, int NoOfEnemies)
        {
            map = new Map(MinWidth, MaxWidth, MinHeight, MaxHeight, NoOfEnemies);
        }

        public bool MovePlayer(Character.Movement direction)
        {
            if (direction == Character.Movement.Left)
            {
                if (map.Hero0.GetX - 1 != 0 && map.Hero0.Vision[2] == null)
                {
                    map.TileMapArray[map.Hero0.GetY, map.Hero0.GetX] = null;
                    map.Hero0.Move(Character.Movement.Left);
                    map.TileMapArray[map.Hero0.GetY, map.Hero0.GetX] = map.Hero0;
                    return true;
                }
            }
            else if (direction == Character.Movement.Right)
            {
                if (map.Hero0.GetX + 2 != map.Mapheight && map.Hero0.Vision[3] == null)
                {
                    map.TileMapArray[map.Hero0.GetY, map.Hero0.GetX] = null;
                    map.Hero0.Move(Character.Movement.Right);
                    map.TileMapArray[map.Hero0.GetY, map.Hero0.GetX] = map.Hero0;
                    return true;
                }
            }
            else if (direction == Character.Movement.Up)
            {
                if (map.Hero0.GetY - 1 != 0 && map.Hero0.Vision[0] == null)
                {
                    map.TileMapArray[map.Hero0.GetY, map.Hero0.GetX] = null;
                    map.Hero0.Move(Character.Movement.Up);
                    map.TileMapArray[map.Hero0.GetY, map.Hero0.GetX] = map.Hero0;
                    return true;
                }
            }
            else
            {
                if (map.Hero0.GetY + 2 != map.Mapwidth && map.Hero0.Vision[1] == null)
                {
                    map.TileMapArray[map.Hero0.GetY, map.Hero0.GetX] = null;
                    map.Hero0.Move(Character.Movement.Down);
                    map.TileMapArray[map.Hero0.GetY, map.Hero0.GetX] = map.Hero0;
                    return true;
                }
            }
            return false;
        }
        public string PlayerAttack(int Enemy)
        {
            bool EnemyInRange = false;

            foreach (Tile T in Map.Hero0.Vision)
            {
                if (T.GetX == map.Enemies0[Enemy].GetX && (T.GetY == map.Enemies0[Enemy].GetY))
                {
                    EnemyInRange = true;
                    break;
                }
            }
            foreach (Tile M in Map.Hero0.Vision)
            {
                if (M.GetX == map.Enemies0[Enemy].GetX && (M.GetY == map.Enemies0[Enemy].GetY))
                {
                    EnemyInRange = true;
                    break;
                }
            }

            if (EnemyInRange)
            {
                map.Hero0.Attack(map.Enemies0[Enemy]);
                return "You did attack" + map.Hero0.GetDamage + " damage to a " + map.Enemies0[Enemy].TileType0
                + "they now have" + map.Enemies0[Enemy].GetHP + "HP";
            }
            else
            {
                return "Target was not in range";
            }
        }

        public void save()
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fs = new FileStream("Save.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs, map);
                }

            }
            catch (Exception map)
            {

            }
        }
    }

       
        
    
}
