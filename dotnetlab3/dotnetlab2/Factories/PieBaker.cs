using System;
using dotnetlab3.Baking;
using dotnetlab3.Kitchen;

namespace dotnetlab3.Factories
{
    
    class PieBaker : IPastryFactory<Pastry, Pie>
    {
        
        public PieBaker()
        {
            Console.WriteLine("PieBaker added");
        }

        public Pie bake(Pastry pastry, Filling filling) {
            return new Pie(pastry.name, filling.name);
        }
    }
}
