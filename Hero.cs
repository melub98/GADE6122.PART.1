using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.MelubuhleMduduziGulaNdebele.ST10093680
{
     class Hero : Character
    {
        public Hero(int X, int Y, int HP, int MaxHP, int Damage, char Symbol) : base(X, Y, 'H')
        {
            this.HP = HP;
            this.MaxHP = MaxHP;
            Damage = 2;
        }
        public override Movement ReturnMove(Movement move)
        {
            bool MoveIsValid = false;
            switch (move)
            {

                case Movement.Up:

                    if (Vision[0].GetType().Name.Equals(nameof(EmptyTile))) { MoveIsValid = true; }

                    break;

                case Movement.Right:

                    if (Vision[1].GetType().Name.Equals(nameof(EmptyTile))) { MoveIsValid = true; }

                    break;

                case Movement.Down:

                    if (Vision[2].GetType().Name.Equals(nameof(EmptyTile))) { MoveIsValid = true; }

                    break;

                case Movement.Left:

                    if (Vision[3].GetType().Name.Equals(nameof(EmptyTile))) { MoveIsValid = true; }

                    break;

            }
            // if statement for no movement
            if (MoveIsValid)

            {

                return move;

            }

            else

            {

                return Movement.NoMovement;

            }

        }
        public override string ToString()
        {
            return ("Player Stats:\nHP:" + HP + "/" + MaxHP + "\n" + "Damage:" + Damage + "\n[" + X + "," + Y + "]");
        }
    }
}
