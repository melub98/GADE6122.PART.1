using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using static Task_1.Character;
using static Task_1.frmUI; 

    
    namespace Task_1 {

    class GameEngine
    {
        private Map map;
         public Map GetMap
         {
            get { return map; }
            set { map = value; }
         }

        bool playerMoved = false;
        bool playerAttacks = false;
        
        public GameEngine()
        {
            map = new Map(10, 10, 15, 15, 6,5);
            
            //MoveEnemy();
            
        }
        
        public void EnemyAttack()
        {
            for (int i = 1; i < map.GetEnemies.Length; i++)
            {
                switch (map.GetEnemies[i].getSymbol)
                {
                    case 'G':
                        for (int a = 0; a < map.GetEnemies[i].Vision.Length; a++)
                        {
                            if (map.GetEnemies[i].Vision[a].getX == map.GetPlayer.getX && map.GetEnemies[i].Vision[a].getY == map.GetPlayer.getY)
                            {
                                map.GetEnemies[i].attack(map.GetPlayer);
                            }
                        }
                    break;
                        case 'M':
                            if (map.GetEnemies[i].checkRange(map.GetPlayer) == true)
                            {
                                map.GetEnemies[i].attack(map.GetPlayer);
                            }
                            for (int b = 0; b < map.GetEnemies.Length; b++)
                            {
                                if (map.GetEnemies[i].checkRange(map.GetEnemies[b]) == true)
                                {
                                    map.GetEnemies[i].attack(map.GetEnemies[b]);
                                }
                            }
                            break;
                                case 'L':
                                    for (int a = 0; a < map.GetEnemies[i].Vision.Length; a++)
                                        {
                                            if (map.GetEnemies[i].Vision[a].getX == map.GetPlayer.getX && map.GetEnemies[i].Vision[a].getY == map.GetPlayer.getY)
                                                {
                                                    map.GetEnemies[i].attack(map.GetPlayer);
                                                }
                                        }
                                    break;
                }
            }
        }

        public void MovePlayer(MovementDirection movement)
        {
            switch (movement)
            {
                case MovementDirection.up:
                    map.GetPlayer.Move(map.GetPlayer.ReturnMove(MovementDirection.up));
                    break;

                case MovementDirection.down:
                    map.GetPlayer.Move(map.GetPlayer.ReturnMove(MovementDirection.down));
                    break;

                case MovementDirection.left:
                    map.GetPlayer.Move(map.GetPlayer.ReturnMove(MovementDirection.left));
                    break;

                case MovementDirection.right:
                    map.GetPlayer.Move(map.GetPlayer.ReturnMove(MovementDirection.right));
                    break;
            }
           
        }

        public string PlayerAttack(int Enemy)
        {
            bool EnemyInRange = false;

            foreach(Tile T in map.GetPlayer.Vision)
            {
                if(T.getX == map.GetEnemies[Enemy].getX && (T.getY == map.GetEnemies[Enemy].getY))
                {
                    EnemyInRange = true;
                    break;
                }
            }
             
            if (EnemyInRange)
            {
                map.GetPlayer.attack(map.GetEnemies[Enemy]);
                return "You did attack" + map.GetPlayer.getDamage + " damage to a " + map.GetEnemies[Enemy].GetTileType
                +"they now have" + map.GetEnemies[Enemy].getHP + "HP";
                //playerAttacks = true;
            }
            else
            {
                return "Target was not in range";
            }
        }        

        public override string ToString()
        {
           return map.DrawMap();
        }


        //Enemy attacking
        public string EnemyAttacks(int Character) {

            return null;

        }

        //Enemy movement
        public void MoveEnemy(MovementDirection moveEnem) 
        {
            for(int i = 0; i < map.GetEnemies.Length; i++)
            {
                map.GetEnemies[i].Move(map.GetEnemies[i].ReturnMove(moveEnem));
            }

            void save()
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

                    //for (int a = 0; a < map.GetLeaders.Length; a++)
                    //{
                    //    map.GetEnemies[a].Move(map.GetLeaders[a].ReturnMove(moveEnem));
                    //}

                    /*
                    if (playerMoved == true) {

                        EnemyAttacks();
                    }

                    if (playerAttacks == true) {
                        EnemyAttacks();

                    }
                    */
                }


        //bool CheckValidMove(MovementDirection charactermove) {
        //    bool valid = false;

        //    switch (charactermove) {
        //        case MovementDirection.right:
        //            if (Vision[2].GetType() == typeof(EmptyTile) || Vision[2].GetType() == typeof(Gold)) {
        //                valid = true;
        //                break;
        //            }
        //            break;
        //        case MovementDirection.left:
        //            if (Vision[3].GetType() == typeof(EmptyTile) || Vision[3].GetType() == typeof(Gold)) {
        //                valid = true;
        //                break;
        //            }
        //            break;
        //        case MovementDirection.down:
        //            if (Vision[1].GetType() == typeof(EmptyTile) || Vision[1].GetType() == typeof(Gold)) {
        //                valid = true;
        //                break;
        //            }
        //            break;
        //        case MovementDirection.up:
        //            if (Vision[0].GetType() == typeof(EmptyTile) || Vision[0].GetType() == typeof(Gold)) {
        //                valid = true;
        //                break;
        //            }
        //            break;
        //    }
        //    return valid;
        //}

    }
}
