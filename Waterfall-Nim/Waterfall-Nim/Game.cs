
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim
{
    /// <summary>
    /// Allows player to play game
    /// Against another player
    /// Against an AI
    /// </summary>
    public class Game
    {
        //bool 
        //is used to check to see if game is done
        private bool done = false;

        //string 
        //is equal to whose turn it is currently
        private string playerTurn;

        /// <summary>
        /// PvP Method
        /// difficulty is passes in
        /// sets up PvP board
        /// </summary>
        /// <param name="difficulty"></param>
        public void PvP(string difficulty)
        {

            //Player
            //creates player one
            Player p1 = new Player();

            //Player
            //creates player two
            Player p2 = new Player();

            Console.WriteLine("Player 1, please enter your name.");
            Console.WriteLine();

            //reads in player one's name and sets it
            p1.PName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Player 2, please enter your name");
            Console.WriteLine();

            //reads in player two's name and sets it
            p2.PName = Console.ReadLine();
            Console.WriteLine();

            //current turn is determined randomly
            playerTurn = Turn();

            //Board
            //creates board
            ///with added difficulty
            models.Board board = new models.Board(difficulty);

            //do while loop
            //continues game 
            //until there is a winner
            do
            {
                //Allows players to make their turn
                playerMove(playerTurn, board);
            } while (!done);
        }

        /// <summary>
        /// PvC Method
        /// Sets up Player Vs AI board
        /// </summary>
        public void PvC()
        {
            //Board
            //creates new board
            //facing AI is automatically easy
            models.Board board = new models.Board("easy");

            //Player
            //creates player one
            Player p1 = new Player();
            Console.WriteLine("Player 1, please enter your name");
            Console.WriteLine();

            //reads in and sets player one's name
            p1.PName = Console.ReadLine();
            Console.WriteLine();

            //starts ai Game
            aiMove(board);

        }

        /// <summary>
        /// Turn Method
        /// Determines randomly who goes first
        /// In PvP
        /// </summary>
        /// <returns>Current player's turn</returns>
        private string Turn()
        {
            //string
            //default turn is player one
            string turn = "p1";

            Random rand = new Random();
            //int
            //creates random number of one or two
            int num = rand.Next(1, 2);

            //if number is two
            //current turn is player two
            if (num == 2)
            {
                //sets current turn to player two
                turn = "p2";
            }

            //returns current players turn
            return turn;
        }

        /// <summary>
        /// aiMove Method
        /// Randomly chooses heap and sticks to remove
        /// </summary>
        /// <param name="board"></param>

        public void aiMove(models.Board board)
        {

            Random rand = new Random();
            
            //int 
            //chooses random heap on board
            int num = rand.Next(board.heaps.Length - 1);

            //int
            //chooses random number of sticks in heap
            int stick = rand.Next(1, board.heaps[num].Sticks);

            //removes sticks from heap
            board.heaps[num].Sticks -= stick;

            //checks who winner is
            //current turn is ai
            //passes in current board state
            aiCheck("ai", board);
        }

        /// <summary>
        /// Allows player to make moves against AI
        /// </summary>
        /// <param name="board">Current Board State</param>
        public void p1Move(models.Board board)
        {
            bool valid = false;
            int count = 0;
            Console.WriteLine("It is player 1's turn.");
            Console.WriteLine();
            Console.WriteLine("There are " + board.heaps.Length + "heaps");
            Console.WriteLine();

            //for loop
            //loops through number of heaps
            //prints heaps and number of sticks in them
            for (int i = 0; i < board.heaps.Length; i++)
            {
                count++;
                Console.WriteLine("Heap number" + count + ": " + board.heaps[i].Sticks + " sticks");
                Console.WriteLine();
            }

            //do while loop
            //ensures user enters valid response

            do
            {
                Console.WriteLine("Enter the heap you wish to access");

                //takes input in regards to current heap
                string input = Console.ReadLine();

                //int
                //is number of heap accessed
                int num;

                //bool
                //try-parses input
                bool bParse = int.TryParse(input, out num);
                Console.WriteLine();

                //if input is invalid
                //user must enter valid response
                if (bParse == false)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine();
                }

                //if input is valid
                else if (bParse == true)
                {
                    //if input is less than one
                    //input is invalid
                    //user must enter a valid response
                    if (num < 1)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                    }

                    //if input is greater than number of heaps on board
                    //input is invalid
                    //user must enter a valid response
                    else if (num > board.heaps.Length)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                    }

                    //if input is valid
                    else
                    {
                        int num2;
                        Console.WriteLine("How many sticks would you like to draw?");

                        //string
                        //takes in user input in regards to number of sticks
                        string input2 = Console.ReadLine();

                        Console.WriteLine();

                        //bool
                        //try-parses user input
                        bool sParse = int.TryParse(input2, out num2);

                        //if input is invalid
                        //user must enter a valid response
                        if (sParse == false)
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine();
                        }

                        //if input is valid

                        else if (sParse == true)
                        {

                            //if less than a stick
                            //input is invalid
                            //user must enter a valid response
                            if (num2 < 1)
                            {
                                Console.WriteLine("You must draw a stick");
                                Console.WriteLine();
                            }
                            //if more than available sticks
                            //input is invalid
                            //user must enter a valid response
                            else if (num2 > board.heaps[num].Sticks)
                            {
                                Console.WriteLine("This move is invalid");
                                Console.WriteLine();
                            }

                            //if input is valid
                            else
                            {
                                //removes number of sticks from current heap
                                board.heaps[num].Sticks -= num2;

                                //check who won
                                //current turn is player one
                                //passes in current board state
                                aiCheck("p1", board);

                                //breaks out of do while loop
                                valid = true;
                            }
                        }
                    }
                }
            } while (!valid);
        }

    

    /// <summary>
    ///playerMove Method
    ///allows current player to make their move
    /// </summary>
    /// <param name="turn">current turn</param>
    /// <param name="board">current board state</param>
    public void playerMove(string turn, models.Board board)
        {
            bool valid = false;
            int count = 0;
            Console.WriteLine("It is " + turn + "'s turn.");
            Console.WriteLine();
            Console.WriteLine("There are " + board.heaps.Length + "heaps");
            Console.WriteLine();

            //for loop
            //loops through number of heaps
            //prints heaps and number of sticks in them
            for (int i = 0; i < board.heaps.Length; i++)
            {
                count++;
                Console.WriteLine("Heap number" + count + ": " + board.heaps[i].Sticks + " sticks");
                Console.WriteLine();
            }

            //do while loop
            //ensures user enters valid response
            do
            {
                Console.WriteLine("Enter the heap you wish to access");
                //string
                //takes input in regards to current heap

                string input = Console.ReadLine();

                //int
                //is number of heap accessed
                int num;

                //bool
                //try-parses input
                bool bParse = int.TryParse(input, out num);
                Console.WriteLine();

                //if input is invalid
                //user must enter a valid response
                if (bParse == false)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine();

                //if input is valid
                } else if (bParse == true)
                {
                    //if less than number of available heaps
                    //input is invalid
                    //user must enter a valid response
                    if (num < 1)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                    }
                    //if input is greater than number of heaps on board
                    //input is invalid
                    //user must enter a valid respon
                    else if (num > board.heaps.Length)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                    }

                    //if input is valid
                    else
                    {

                        int num2;
                        Console.WriteLine("How many sticks would you like to draw?");

                        //string
                        //takes in user input in regards to number of sticks
                        string input2 = Console.ReadLine();
                        Console.WriteLine();

                        //bool
                        //try-parses input
                        bool sParse = int.TryParse(input2, out num2);

                        //if input is invalid
                        //user must enter valid response
                        if (sParse == false)
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine();
                        }
                        else if (sParse == true)
                        {
                            //if less than a stick
                            //input is invalid
                            //user must enter a valid response
                            if (num2 < 1)
                            {
                                Console.WriteLine("You must draw a stick");
                                Console.WriteLine();
                            }
                            //if more than available sticks
                            //input is invalid
                            //user must enter a valid response
                            else if (num2 > board.heaps[num-1].Sticks)
                            {
                                Console.WriteLine("This move is invalid");
                                Console.WriteLine();
                            }
                            //if input is valid
                            else
                            {
                                //removes number of sticks from current heap
                                   board.heaps[num - 1].Sticks -= num2;
                                //checks winner
                                //passes in current turn
                                Check(turn, board);

                                //if current turn is player 1
                                if (playerTurn == "p1")
                                {
                                    //current turn is now player 2
                                    playerTurn = "p2";
                                }

                                //if current turn is player two
                                else if (playerTurn == "p2")
                                {
                                    //current turn is now player one
                                    playerTurn = "p1";
                                }
                                //braks out of do while loop
                                valid = true;
                            }
                        }
                    }
                    }
                } while (!valid) ;
            }

        /// <summary>
        /// Check Method
        /// checks who winner is in pvp
        /// </summary>
        /// <param name="player">Current player</param>
        /// <param name="board">Current board state</param>
        private void Check(string player, models.Board board)
        {
            //if current player is player one
            //if no more heaps on board
            if(player == "p1" && board.heaps.Length == 0)
            {
                //winner is player two
                Console.WriteLine("Player 2 wins");
                
                //ends game
                done = true;
            //if current player is player two
            //if no more heaps on board
            }else if(player == "p2" && board.heaps.Length == 0)
            {
                //winner is player one
                Console.WriteLine("Player 1 wins");

                //ends game
                done = true;
            }
        }

        /// <summary>
        ///aiCheck Method
        ///checks who one in PvC
        /// </summary>
        /// <param name="turn">Current turn</param>
        /// <param name="board">Current board state</param>
        private void aiCheck(string turn, models.Board board)
        {
            //if current player is player one
            //if no more heaps on board
            if (turn == "p1" && board.heaps.Length == 0)
            {
                //winner is AI
                Console.WriteLine("AI wins");
                Console.WriteLine();

                //ends game
                done = true;
                //if current player is AI
                //if no more heaps on board
            }
            else if (turn == "ai" && board.heaps.Length == 0)
            {
                //winner is Player one
                Console.WriteLine("Player 1 wins");

                //ends game
                done = true;

                //if current turn is ai
                //if heaps are available

            } else if (turn == "ai" && board.heaps.Length != 0)
            {
                //player one's turn
                p1Move(board);

            //if current turn is player one
            //if heaps are available
            } else if (turn == "p1" && board.heaps.Length != 0){

                //AI's turn
                aiMove(board);
            }
        }
    }
}
