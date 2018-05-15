using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim.models
{
    public class Board
    {
        public Heap[] heaps;
        public Board(string difficulty)
        {
            switch (difficulty.ToLower())
            {
                case "easy": //Easy
                    heaps = new Heap[] { new Heap() { Sticks = 3 }, new Heap() { Sticks = 3 } };
                    break;
                case "medium": //Medium
                    heaps = new Heap[] { new Heap() { Sticks = 2 }, new Heap() { Sticks = 5 }, new Heap() { Sticks = 7 } };
                    break;
                case "hard": //Hard
                    heaps = new Heap[] { new Heap() { Sticks = 2 }, new Heap() { Sticks = 3 }, new Heap() { Sticks = 8 }, new Heap() { Sticks = 9 } };
                    break;
            }
        }

    }
}
