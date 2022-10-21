using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    //Q2.2
     abstract class Character : Tile        //character class used to make enemies and character
    {
        //Protected member variables
        protected int HP;
        protected int MaxHP;
        protected int Damage;
        protected int Purse;
        public Tile[] Vision = new Tile[4];

        public Character(int x, int y, TileType tileType, char symbol, int hp, int maxhp, int damage, int purse) : base(x, y, tileType, symbol)
        {
            Symbol = symbol;
            HP = hp;
            MaxHP = maxhp;
            Damage = damage;
            Purse = purse;
        }

        public int getHP
        {
            get { return HP;}
            set { HP = value; }
        }

        public int getmaxHP
        {
            get { return MaxHP; }
            set { MaxHP = value; }
        }

        public int getDamage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public int getPurse
        {
            get { return Purse; }
            set { Purse = value; }

        }

        public void setPurse(int purse) {
            this.Purse = purse;
        }

        public enum MovementDirection
        {
            idle,                       //no movement
            up,
            right,
            down,
            left
        }

        public virtual void attack(Character Target)
        {
            if(checkRange(Target))
            {
                Target.HP -= Damage;                //Decreases health of target
            }
            
        }

        public bool isdead()
        {
            if(HP <= 0)
            {
                return true;
            }
            else return false;
        }

        public virtual bool checkRange(Character Target)
        {
            if (DistanceTo(Target) > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int DistanceTo(Character character)      //Figures out number of spaces for movement
        {
            int num = X + Y;
            int num2 = character.X + character.Y;
            int num3 = Math.Abs(num - num2);
            return num3;
        }

        public void Move(MovementDirection move)
        {
            switch(move)
            {
                case MovementDirection.up:
                    Y = Y - 1;
                    break;
                case MovementDirection.down:
                    Y = Y + 1;
                    break;
                case MovementDirection.left:
                    X = X - 1;
                    break;
                case MovementDirection.right:
                    X = X + 1;
                    break;
                case MovementDirection.idle:
                    break;
            }
        }

        public void Pickup(Item i)
        {
            Gold gold = (Gold)i;
            Purse = Purse + gold.GetAmount;
        }

        public abstract MovementDirection ReturnMove(MovementDirection m);

        public abstract override string ToString();
    }
}
