using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim.models
{
    /// <summary>
    /// Board class
    /// Creates new board 
    /// Board has Heaps and sticks
    /// </summary>
    public class Board
    {
        //Heap
        //array of heaps on board
        public Heap[] heaps;
        
        /// <summary>
        /// Creates board
        /// </summary>
        /// <param name="difficulty">Chosen difficulty</param>
        public Board(string difficulty)
        {
            //switch
            //creates board according to difficulty
            switch (difficulty.ToLower())
            {
                //if easy
                //two heaps
                //both have 3 sticks
                case "easy": //Easy
                    heaps = new Heap[] { new Heap() { Sticks = 3 }, new Heap() { Sticks = 3 } };
                    break;
                //if medium
                //three heaps
                //one heap has two sticks
                //one hap has five sticks
                //one heap has seven sticks
                case "medium": //Medium
                    heaps = new Heap[] { new Heap() { Sticks = 2 }, new Heap() { Sticks = 5 }, new Heap() { Sticks = 7 } };
                    break;
                //if hard
                //four heaps
                //one heap has two sticks
                //one heap has three sticks
                //one heap has eight sticks
                //one heap has nine sticks
                case "hard": //Hard
                    heaps = new Heap[] { new Heap() { Sticks = 2 }, new Heap() { Sticks = 3 }, new Heap() { Sticks = 8 }, new Heap() { Sticks = 9 } };
                    break;
            }
        }

    }
}
