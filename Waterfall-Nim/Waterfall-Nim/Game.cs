
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim
{
    public class Game
    {
        private bool done = false;
        private string playerTurn;

        public void PvP(string difficulty)
        {

            Player p1 = new Player();
            Player p2 = new Player();

            Console.WriteLine("Player 1, please enter your name.");
            Console.WriteLine();

            p1.PName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Player 2, please enter your name");
            Console.WriteLine();

            p2.PName = Console.ReadLine();
            Console.WriteLine();

            playerTurn = Turn();
            models.Board board = new models.Board(difficulty);

            do
            {
                playerMove(playerTurn, board);
            } while (!done);
        }

        public void PvC()
        {

        }

        private string Turn()
        {
            string turn = "p1";
            Random rand = new Random();
            int num = rand.Next(1, 2);
            if (num == 2)
            {
                turn = "p2";
            }

            return turn;
        }


        public void playerMove(string turn, models.Board board)
        {
            bool valid = false;
            int count = 0;
            Console.WriteLine("It is " + turn + "'s turn.");
            Console.WriteLine();
            Console.WriteLine("There are " + board.heaps.Length + "heaps");
            Console.WriteLine();

            for (int i = 0; i < board.heaps.Length; i++)
            {
                count++;
                Console.WriteLine("Heap number" + count + ": " + board.heaps[i].Sticks + " sticks");
                Console.WriteLine();
            }

            do
            {
                Console.WriteLine("Enter the heap you wish to access");
                string input = Console.ReadLine();
                int num;
                bool bParse = int.TryParse(input, out num);
                Console.WriteLine();

                if (bParse == false)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine();
                } else if (bParse == true)
                {
                    if (num < 1)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                    }
                    else if (num > board.heaps.Length)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                    }
                    else
                    {
                        int num2;
                        Console.WriteLine("How many sticks would you like to draw?");
                        string input2 = Console.ReadLine();
                        Console.WriteLine();
                        bool sParse = int.TryParse(input2, out num2);

                        if (sParse == false)
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine();
                        }
                        else if (sParse == true)
                        {
                            if (num2 < 1)
                            {
                                Console.WriteLine("You must draw a stick");
                                Console.WriteLine();
                            }
                            else if (num2 > board.heaps[num].Sticks)
                            {
                                Console.WriteLine("This move is invalid");
                                Console.WriteLine();
                            }
                            else
                            {
                                board.heaps[num].Sticks -= num2;
                                Check(turn, board);
                                if (playerTurn == "p1")
                                {
                                    playerTurn = "p2";
                                }
                                else if (playerTurn == "p2")
                                {
                                    playerTurn = "p1";
                                }
                                valid = true;
                            }
                        }
                    }
                    }
                } while (!valid) ;
            }

        private void Check(string player, models.Board board)
        {
            if(player == "p1" && board.heaps.Length == 0)
            {
                Console.WriteLine("Player 2 wins");
                done = true;
            }else if(player == "p2" && board.heaps.Length == 0)
            {
                Console.WriteLine("Player 1 wins");
                done = true;
            }
        }
    }
}
