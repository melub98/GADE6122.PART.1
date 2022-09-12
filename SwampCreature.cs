using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.PART._1
{
     class SwampCreature : Enemy
    {
        public SwampCreature(int X, int Y, int Damage, int HP) : base(X, Y, 1, 10, 10, 'S')
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            
            int RndMove = RandomObj.Next(0, Vision.Length);
            while (Vision[RndMove].GetType() != typeof(EmptyTile))
            {
                RndMove = RandomObj.Next(0, Vision.Length);
            }


            switch (RndMove)
            {

                case 0:
                    return Movement.Up;
                case 1:
                    return Movement.Down;
                case 2:
                    return Movement.Right;
                case 3:
                    return Movement.Left;
                default:
                    return Movement.NoMovement;
            }

            

            
            
            
          
        }
    
    }
}
