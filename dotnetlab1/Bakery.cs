using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnetlab1
{
    /// <summary>
    /// This is where all the bakers work and make pastry
    /// </summary>
    class Bakery : IEnumerable<IBaker>
    {
        public List<IBaker> workers = new List<IBaker>();
        public Fridge fridge = new Fridge();
        /// <summary>
        /// like when you open a bakery
        /// </summary>
        public Bakery()
        {
            Console.WriteLine("Bakery opened!");
            workers.Add(new PuffBaker(this));
            workers.Add(new YeastBaker(this));
        }

        IEnumerator<IBaker> IEnumerable<IBaker>.GetEnumerator()
        {
            return workers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return workers.GetEnumerator();
        }
    }
}
