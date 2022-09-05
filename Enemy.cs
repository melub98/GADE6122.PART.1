using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.PART._1
{
    abstract class Enemy : Character
    {
        public Random RandomObj = new Random();
        protected int RndObject;
        public int rndObject { set { RndObject = RandomObj.Next(1, 5); } get { return RndObject; } }
        public Enemy(int X, int Y, int Damage, int HP, int MaxHP, char Symbol) : base(X, Y, Symbol)
        {

            GetDamage = Damage;
            GetHP = HP;
            GetMaxHP = MaxHP;

        }
        public override string ToString()
        {
            return ("Enemy at[" + X + "," + Y + "]" + Damage + "Amount DMG");
        }
    }
}
