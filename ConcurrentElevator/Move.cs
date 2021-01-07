using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentElevator
{
    class Move
    {
        public int to;
        public int from;

        public Move(int t, int f)
        {
            to = t;
            from = f;
        }


    }
}
