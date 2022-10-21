using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    class SwampCreature : Enemy
    {

        public SwampCreature(int x, int y, TileType tileType) : base(x, y, tileType, 'C',1 ,10, 10)
        {

        }

        public override MovementDirection ReturnMove(MovementDirection move = MovementDirection.idle)
        {
            int randomTile = rnd.Next(0, Vision.Length);
            while (Vision[randomTile].GetType() != typeof(EmptyTile))
            {
                randomTile = rnd.Next(0, Vision.Length);
            }
            switch (randomTile)
            {
                
                case 0:
                    return MovementDirection.up;                    //Get Creature to move randomly
                case 1:
                    return MovementDirection.down;
                case 2:
                    return MovementDirection.right;
                case 3:
                    return MovementDirection.left;
                default:
                    return MovementDirection.idle;
            }
        }
    }
}
