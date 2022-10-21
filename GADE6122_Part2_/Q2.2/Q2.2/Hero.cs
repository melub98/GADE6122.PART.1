using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    class Hero: Character
    {

        public Hero(int x, int y, TileType tileType) : base(x, y, tileType, 'H', 100, 10, 2,0)
        {

        }

        bool CheckValidMove(MovementDirection charactermove)
        {
            bool valid = false;

            switch (charactermove)
            {
                case MovementDirection.right:
                        if(Vision[2].GetType() == typeof(EmptyTile) || Vision[2].GetType() == typeof(Gold))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case MovementDirection.left:
                    if (Vision[3].GetType() == typeof(EmptyTile) || Vision[3].GetType() == typeof(Gold))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case MovementDirection.down:
                    if (Vision[1].GetType() == typeof(EmptyTile) || Vision[1].GetType() == typeof(Gold))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case MovementDirection.up:
                    if (Vision[0].GetType() == typeof(EmptyTile) || Vision[0].GetType() == typeof(Gold))
                    {
                        valid = true;
                        break;
                    }
                    break;
            }
            return valid;
        }
        


        public override MovementDirection ReturnMove(MovementDirection move = MovementDirection.idle)
        {
            if (CheckValidMove(move))
            {
                currentPosition = move;
                return move;
            }
            else return MovementDirection.idle;
        }

        public override string ToString()
        {
            return "Player Stats:" + '\n' + "HP: " + HP + "/ "+ MaxHP+ '\n' + "Damage: " + Damage + '\n' + "[" + X + "," + Y + "] " + getPurse + " Gold";
        }

        MovementDirection currentPosition = MovementDirection.idle;

        public MovementDirection getTargetCurrentPosition() {
            return this.currentPosition;
        }



    }
}
