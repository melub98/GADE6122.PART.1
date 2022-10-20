using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.PART._1
{
    class Mage : Enemy
    {
        public Mage(int X, int Y, int Damage, int HP) : base(X, Y, 1, 5, 5, 'M')
        {

        }

        public override bool CheckRange(Character Target)
        {
            if (Target.GetX == X - 1 && Target.GetY == Y - 1)
            {
                return true;
            }

            else if (Target.GetX == X - 1 && Target.GetY == Y + 1)
            {
                return true;
            }

            else if (Target.GetX == X + 1 && Target.GetY == Y - 1)
            {
                return true;
            }

            else if (Target.GetX == X + 1 && Target.GetY == Y + 1)
            {
                return true;
            }

            else if (Target.GetX == X + 1 && Target.GetY == Y)
            {
                return true;
            }
            else if (Target.GetX == X - 1 && Target.GetY == Y)
            {
                return true;
            }
            else if (Target.GetX == X && Target.GetY == Y + 1)
            {
                return true;
            }
            else if (Target.GetX == X && Target.GetY == Y - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {

            int RndMove = RandomObj.Next(0, Vision.Length);
            while (Vision[RndMove].GetType() != typeof(EmptyTile))
            {
                RndMove = RandomObj.Next(0, Vision.Length);
            }


            
                    return Movement.NoMovement;
            
        }
    }
}