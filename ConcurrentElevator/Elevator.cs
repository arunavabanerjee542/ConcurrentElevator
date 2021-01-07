using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentElevator
{
    class Elevator
    {
        public int currentfloor;

        public Elevator()
        {
            currentfloor = 0;
        }

        public static async Task DetermineAndMove(Move m)
        {
            int to = m.to;
            int from = m.from;
           
            if(to<from)
            {
               await Moveup(to, from);
            }
            else
            {
               await MoveDown(to, from);
            }


        }



       static public async Task Moveup(int to,int from)
        {

            while(to<from)
            {
                Console.WriteLine(" TO ---> "+ to  + " FROM ---> "+ ++to );

                await Task.Delay(1000);
            }

        }

      static  public async Task MoveDown(int to,int from)
        {
            
            while(to>from)
            {
                Console.WriteLine(" TO ---> " + to + " FROM ---> " + --to);
                await Task.Delay(1000);
            }

        }

    }
}
