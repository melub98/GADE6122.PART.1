using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    class Gold : Item   //Q2.2
    {

        private int amount;

        public int GetAmount
        {
            get { return amount; }
            set { amount = value; }
        }

        private Random rnd = new Random();

        public Gold(int x, int y, TileType tileType) : base(x, y, tileType, '$')
        {
            amount = rnd.Next(1,6);
        }

        public override string ToString()
        {
            return "You have recieved " + amount + " gold";
        }
    }
}
