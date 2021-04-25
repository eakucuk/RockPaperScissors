using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int win1 = 0, win2 = 0;
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int player2 = random.Next(0, 3);
                if (player2 == 0)
                {
                    win2++;
                }
                else if(player2 == 2)
                {
                    win1++;
                }
            }
            Console.WriteLine("Player A wins "+win1+ " of 100 games");
            Console.WriteLine("Player B wins " + win2 + " of 100 games");
            Console.WriteLine("Tie: " + (100-win1-win2) + " of 100 games");

            Console.ReadLine();


        }
    }
}
