using dotnetlab1.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class Bakery
    {
        public IBaker puffBaker;
        public IBaker yeastBaker;
        
        public Bakery()
        {
            Console.WriteLine("Bakery opened!");
            puffBaker = new PuffBaker();
            yeastBaker = new YeastBaker();
        }
    }
}
