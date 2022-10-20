using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122.PART._1
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

            public Gold(int x, int y, char Symbol) : base(x, y, '$')
            {
                amount = rnd.Next(1, 6);
            }

            public override string ToString()
            {
                return "You have recieved " + amount + " gold";
            }
        }
    }


