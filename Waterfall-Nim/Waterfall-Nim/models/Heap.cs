using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim.models
{
    public class Heap
    {
        public int Sticks { get; set; }

        public void Remove(int sticks)
        {
            Sticks -= sticks;
        }

        public bool isEmpty()
        {
           return (Sticks == 0) ? true : false;
        }
    }
}
