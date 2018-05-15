using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim
{
    public class Program
    {
         public static void Main(string[] args)
        {
            Start();   
        }

        public static void Start()
        {
            bool valid = false;
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. Read instructions");
                string input = Console.ReadLine();
                Console.WriteLine();
                input = input.ToUpper();
                if (input.Contains("1") || input.Contains("play"))
                {
                    // start game
                    valid = true;
                }
                else if (input.Contains("2") || input.Contains("read"))
                {
                    Instructions();
                }else if(input == "" || input == null)
                {
                    Console.WriteLine("Input was invalid");
                }
                else
                {
                    Console.WriteLine("Input was invalid");
                }
            } while (!valid);
        }

        public static void Instructions()
        {
            bool valid = false;
            do
            {
                Console.WriteLine("1. You may remove any number of sticks from any heap");
                Console.WriteLine();
                Console.WriteLine("2. If you are the one to remove the last stick, you lose");
                Console.WriteLine();
                Console.WriteLine("Press B to go back");
                Console.WriteLine();
                string input = Console.ReadLine();
                input = input.ToUpper();
                if (input == "B")
                {
                    Start();
                }
                else if (input == "" || input == null)
                {
                    Console.WriteLine("Input was invalid");
                }
                else
                {
                    Console.WriteLine("Input was invalid");
                }
            } while (!valid);
        }

        public void Choice()
        {
            bool valid = false;
            do
            {
                Console.WriteLine("Choose one...");
                Console.WriteLine();
                Console.WriteLine("1. Player vs Player");
                Console.WriteLine("2. Player vs AI");
                Console.WriteLine();
                string input = Console.ReadLine();
                Console.WriteLine();
                if (input.Contains("1"))
                {
                    Difficulty("pvp")
                }else if (input.Contains("2"))
                {
                    Difficulty("AI");
                }
            } while (!valid);
        }

        public string Difficulty(string player)
        {
            if(player == "pvp")
            {
                //pvp
            }else if(player == "ai")
            {
                //ai
            }
            return player;
        }
    }
}
