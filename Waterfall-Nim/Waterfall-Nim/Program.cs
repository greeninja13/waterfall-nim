using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim
{
    /// <summary>
    /// The program class
    /// This class contains all the necessary methods to start the game
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This class starts game
        /// </summary>
        /// <param name="args"></param>
         public static void Main(string[] args)
        {
            Start();   
        }

        /// <summary>
        /// Start Method
        /// This class provides a small menu 
        ///     Asks user if they would like to play or read instructions
        ///
        /// </summary>
        public static void Start()
        {
            bool valid = false;

            //do while loop
                //ensures that the user provides a valid response
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. Read instructions");

                //Takes in user input
                    //Regargding playing or reading instructions
                string input = Console.ReadLine();
                Console.WriteLine();

                //converts user input into uppercase to make if statements easier
                input = input.ToUpper();

                //if user input is valid
                //if input is play game
                    //provides next set of options for user
                if (input.Contains("1") || input.Contains("play"))
                {
                    Choice();
                    valid = true;
                }
                //if input is valid
                //if input is read instructions
                    //provides instructions for user
                else if (input.Contains("2") || input.Contains("read"))
                {
                    Instructions();
                //if input is empty or null
                    //input is invalid
                    //user must enter proper response
                }else if(input == "" || input == null)
                {
                    Console.WriteLine("Input was invalid");
                }
                //if input is not an option in menu
                    //input is invalid
                    //user must enter proper response
                else
                {
                    Console.WriteLine("Input was invalid");
                }
            } while (!valid);
        }

        /// <summary>
        /// Instructions Method
        /// Provides instructions on how to play the game
        /// </summary>
        public static void Instructions()
        {
            bool valid = false;

            //do while loop
            //ensure user enters a valid response
            do
            {
                Console.WriteLine("1. You may remove any number of sticks from any heap");
                Console.WriteLine();
                Console.WriteLine("2. If you are the one to remove the last stick, you lose");
                Console.WriteLine();
                Console.WriteLine("Press B to go back");
                Console.WriteLine();

                //takes in user input
                    //in order to go to previous menu
                string input = Console.ReadLine();

                //converts user input to uppercase
                //makes if statement easier
                input = input.ToUpper();

                //if input is valid
                //if input is correct
                    //goes back to previous menu
                if (input == "B")
                {
                    
                    Start();
                }
                //if input is empty or null
                    //input is invalid
                    //user must enter proper response
                else if (input == "" || input == null)
                {
                    Console.WriteLine("Input was invalid");
                }
                //if input is not b
                    //input is invalid
                    //user must enter proper response
                else
                {
                    Console.WriteLine("Input was invalid");
                }
            } while (!valid);
        }

        /// <summary>
        /// Choice class
        ///Gives user next set of choices
        ///Choices in regards to who user will be facing
        ///Player v Player
        ///Player v AI
        /// </summary>

        public static void Choice()
        {
            bool valid = false;
            //do while loop
                //ensures user enters valid response
            do
            {
                Console.WriteLine("Choose one...");
                Console.WriteLine();

                Console.WriteLine("1. Player vs Player");
                Console.WriteLine("2. Player vs AI");
                Console.WriteLine();

                //takes in user input in regards to opponent
                string input = Console.ReadLine();
                Console.WriteLine();

                //if user chooses PvP
                //user chooses difficulty
                if (input.Contains("1"))
                {
                    Difficulty();

                    //if user chooses PvC
                    //Starts AI game
                }
                else if (input.Contains("2"))
                {
                    Game game = new Game();
                    game.PvC();
                }
                //if input is empty or null
                    //invalid input
                    //user must enter proper response
                else if (input == "" || input == null)
                {
                    Console.WriteLine("Input was Invalid");
                    Console.WriteLine();
                }
                //if input is not a choice
                    //input is invalid
                    //user must enter proper response
                else
                {
                    Console.WriteLine("Input was Invalid");
                    Console.WriteLine();
                }
            } while (!valid);
        }
        /// <summary>
        /// Difficulty Method
        /// If PvP
        /// Allows player to select difficulty
        /// </summary>

        public static void Difficulty()
        {
            bool valid = false;
            //string
            //default difficulty is easy
            string difficulty = "easy";

            //do while loop
            //ensures player enters valid response
            do
            {
                Console.WriteLine("Choose a difficulty");
                Console.WriteLine();
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Hard");
                Console.WriteLine();

                //string
                //reads input
                //converts input into uppercase 
                    //to make if statement easier
                string input = Console.ReadLine().ToUpper();

                //if input is valid
                //if user chooses easy
                if (input == "1" || input == "EASY")
                {
                    //sets difficulty to easy
                    difficulty = "easy";

                    //user entered valid response
                    //breaks out of do while loop
                    valid = true;

                //if input is valid
                //if user chooses medium
                }else if(input == "2" || input == "MEDIUM")
                {
                    //sets difficulty to medium
                    difficulty = "medium";

                    //user entered valid response
                    //breaks out of do while loop
                    valid = true;
                //if input is valid
                //if user chooses hard
                }else if(input == "3" || input == "HARD")
                {   //sets difficulty to hard
                    difficulty = "hard";

                    //user entered valid response
                    //breaks out of do while loop
                    valid = true;

                //if input is empty or null
                    //input is invalid
                    //user must enter a valid response
                }else if(input == "" || input == null)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                }
                //if user enters what is not an option
                    //input is invalid
                    //user must enter a valid response
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                }
            } while (!valid);

            //Game
            //creates a new Game
            Game game = new Game();

            //starts new PvP Game
            //with added difficulty
            game.PvP(difficulty);
        }
    }
}
