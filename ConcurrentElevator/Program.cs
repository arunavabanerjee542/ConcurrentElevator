using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentElevator
{
    class Program
    {

        // OUR ELEVATOR CAN MOVE UP/DOWN AND OLSO CONCURRENTLY TAKE
        // AND PROCESS USER REQUEST 



        static void Main(string[] args)
        {
            List<Task> t = new List<Task>();

            List<Move> moves = new List<Move>();

          object l = new object();

            while(1==1)
            {

                //Task.Factory.StartNew(() => AddMove(moves));

                AddMove(moves);

                Task.Factory.StartNew(async () =>
                {
                    if (moves.Count > 0)
                    {
                        
                            await Elevator.DetermineAndMove(moves[0]);
                            moves.Remove(moves[0]);
                        
                    }


                }

                



                              
                );





            }




        }


        public static void AddMove(List<Move> l)
        {
            Console.WriteLine(" To ---> ");
          int t =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" From ---> ");
           int f = Convert.ToInt32(Console.ReadLine());

            l.Add(new Move(t, f));

            
        }

/*
        public static void ShowMoves(Move m)
        {
            int to = m.to;
            int from = m.from;

            if()




        }


*/




    }
}
