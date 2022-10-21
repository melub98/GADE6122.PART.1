using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1    //Q2.2
{
    class Mage : Enemy 
    {
        public Mage(int x, int y, TileType tileType) : base(x, y, tileType, 'M', 5, 5, 5)
        {

        }

       public override bool checkRange(Character Target)
        {
            if (Target.getX == X - 1 && Target.getY == Y - 1)
            {
                return true;
            }

            else if (Target.getX == X - 1 && Target.getY == Y + 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y - 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y + 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y)
            {
                return true;
            }
            else if (Target.getX == X - 1 && Target.getY == Y)
            {
                return true;
            }
            else if (Target.getX == X && Target.getY == Y + 1)
            {
                return true;
            }
            else if (Target.getX == X && Target.getY == Y - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override MovementDirection ReturnMove(MovementDirection move = MovementDirection.idle)
        {
            return MovementDirection.idle;
        }
    }
}
