using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.MelubuhleMduduziGulaNdebele.ST10093680
{
     class SwampCreature : Enemy
    {
        public SwampCreature(int X, int Y, int Damage, int HP) : base(X, Y, 1, 10, 10, 'S')
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            int RndMove = RandomObj.Next(1, 5);


            if (RndMove == 1)
            {
                move = Movement.Up;
            }

            if (RndMove == 2)
            {
                move = Movement.Down;
            }

            if (RndMove == 3)
            {
                move = Movement.Right;
            }

            if (RndMove == 4)
            {
                move = Movement.Left;
            }

            if (RndMove == 5)
            {
                move = Movement.NoMovement;
            }

            return move;
        }
    }
}
