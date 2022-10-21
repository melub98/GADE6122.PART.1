using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    abstract class Enemy : Character        //inherits from Character
    {
        protected Random rnd = new Random();

        public  Enemy(int x, int y, TileType tileType, char symbol, int dmg, int EnemyHP, int MaxEnemyHP) : base(x, y, tileType, symbol, dmg, EnemyHP, MaxEnemyHP, 0)
        {
            Damage = dmg;
            MaxHP = MaxEnemyHP;
            HP = EnemyHP;
        }

        public override string ToString()
        {
            string output = GetType().Name+'\n'+ " at["+ X +","+ Y+"]  \n "+ HP+" HP \n"+"{"+ Damage+"}";
            return output;
        }
    }
}