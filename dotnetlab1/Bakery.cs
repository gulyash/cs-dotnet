using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnetlab1
{
    class Bakery : IEnumerable<IBaker>
    {
        public List<IBaker> workers = new List<IBaker>();
        public Fridge fridge = new Fridge();
     
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
