
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim
{
   public class Game
    {
        
        public void PvP(string difficulty)
        {
           
            Player p1 = new Player();
            Player p2 = new Player();
            Console.WriteLine("Player 1, please enter your name.");
            Console.WriteLine();
            p1.PName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Player 2, please enter your name");
            p2.PName = Console.ReadLine();
            Console.WriteLine();
            string turn = Turn();
            models.Board board = new models.Board(difficulty);
        }

        public void PvC()
        {

        }

        private string Turn()
        {
            string turn = "p1";
            Random rand = new Random();
            int num = rand.Next(1,2);
            if(num == 2)
            {
                turn = "p2";
            }

            return turn;
        }
    }
}
