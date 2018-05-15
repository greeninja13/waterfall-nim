using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim.models
{
    public class Board
    {
        private Heap[] heaps;
        public Board(int difficulty)
        {
            switch (difficulty)
            {
                case 1: //Easy
                    heaps = new Heap[] { new Heap() { Sticks = 3 }, new Heap() { Sticks = 3 } };
                    break;
                case 2: //Medium
                    heaps = new Heap[] { new Heap() { Sticks = 2 }, new Heap() { Sticks = 5 }, new Heap() { Sticks = 7 } };
                    break;
                case 3: //Hard
                    heaps = new Heap[] { new Heap() { Sticks = 2 }, new Heap() { Sticks = 3 }, new Heap() { Sticks = 8 }, new Heap() { Sticks = 9 } };
                    break;
            }
        }

    }
}
