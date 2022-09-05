using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.MelubuhleMduduziGulaNdebele.ST10093680
{
    abstract class Character : Tile
    {
        // protected member variables and their public accessors
        protected int HP;
        protected int MaxHP;
        protected int Damage;
        public Tile[] Vision = new Tile[4];// tile array for players vision
        public int GetHP { set { HP = value; } get { return HP; } }

        public int GetMaxHP { set { MaxHP = value; } get { return MaxHP; } }

        public int GetDamage { set { Damage = value; } get { return Damage; } }


        public string[] GetVision { set; get; }


        public enum Movement { NoMovement, Up, Down, Left, Right }// public enum for movement


        public Character(int X, int Y, char Symbol) : base(X, Y)
        {
            this.X = X;
            this.Y = Y;
            this.Symbol = Symbol;
        }
        public virtual void Attack(Character Target)//method for attacking a player and decreasing the targets health
        {
            this.Damage = -Target.HP;
        }
        public bool IsDead(int HP)//bool for checking if character is dead or alive
        {
            if (this.HP >= 0)
            {
                return false;
            }
            else

                return true;
        }

        public virtual bool CheckRange(Character Target)//bool that Checks if a target is in range of a character
        {
            if (DistanceTo(Target) <= 1 && DistanceTo(Target) >= -1)
            {
                return true; //enenmy is cose range
            }
            else
            {
                return false;// enemy is not in range
            }
        }
        private int DistanceTo(Character Target)//this method Determines the absolute distance(number of spaces needed to move
        {

            int distance = (this.X - Target.X) + (this.Y - Target.Y);
            int value = Math.Abs(distance);
            return value;
        }
        public void Move(Movement move)
        {
            if (move == Movement.Up)
            {
                this.Y++;
            }

            if (move == Movement.Down)
            {
                this.Y--;
            }

            if (move == Movement.Left)
            {
                this.X--;
            }

            if (move == Movement.Right)
            {
                this.X++;
            }
        }
        public abstract Movement ReturnMove(Movement move = 0);
        public abstract override string ToString();
    }
}
