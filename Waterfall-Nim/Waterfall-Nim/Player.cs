using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim
{
    public class Player
    {
        private string p1Name;

        public string P1Name
        {
            get { return p1Name; }
            set { p1Name = value; }
        }

        private string p2Name;

        public string P2Name
        {
            get { return p2Name; }
            set { p2Name = value; }
        }

        public void Name()
        {
            Console.WriteLine("Player 1, what is your name?");
            Console.WriteLine();
            P1Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Player 2, what is your name?>");
            Console.WriteLine();
            P2Name = Console.ReadLine();
            Turn();
        }

        public string Turn()
        {
            string playerTurn = "p1";
            Random rand = new Random();
            int num = rand.Next(1, 2);
            if (num == 2)
            {
                playerTurn = "p2";
            }

            return playerTurn;
        }
    }
}
