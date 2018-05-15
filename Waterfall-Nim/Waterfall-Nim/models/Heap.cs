using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_Nim.models
{
    /// <summary>
    /// Heap Class
    /// Creates Heap
    /// Heaps have set number of sticks
    /// </summary>
    public class Heap
    {
        //int 
        //gets and sets number of sticks in heap
        public int Sticks { get; set; }

        /// <summary>
        /// Remove Method
        /// removes number of sticks in a heap
        /// </summary>
        /// <param name="sticks">number of sticks chosen</param>
        public void Remove(int sticks)
        {
            //removes sticks
            //sets current number of sticks to result
            Sticks -= sticks;
        }

        /// <summary>
        /// isEmpty Method
        /// checks if heap is empty
        /// </summary>
        /// <returns>bool</returns>
        public bool isEmpty()
        {
            //if heap is empty
                //return true
            //if heap is not empty
                //return false
           return (Sticks == 0) ? true : false;
        }
    }
}
