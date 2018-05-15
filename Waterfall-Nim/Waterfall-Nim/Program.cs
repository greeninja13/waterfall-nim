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
            
        }

        public static void Menu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Read instructions");
            string input = Console.ReadLine();
            input = input.ToUpper();
            if (input.Contains("1") || input.Contains("play"))
            {
                // start game
            }
            else if (input.Contains("2") || input.Contains("read"))
            {
                Instructions();
            }
        }

        public static void Instructions()
        {
            Console.WriteLine("1. You may remove any number of sticks from any heap");
            Console.WriteLine();
            Console.WriteLine("2. If you are the one to remove the last stick, you lose");
            Console.WriteLine();
            Console.WriteLine("Press B to go back");
            Console.WriteLine();
            string input = Console.ReadLine();
            input = input.ToUpper();
            if(input == "B")
            {
                Menu();
            }
            else
            {
            }

        }
    }
}
