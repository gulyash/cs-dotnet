using System;
using dotnetlab5.Baking;
using dotnetlab5.Kitchen;

namespace dotnetlab5.Factories
{
    
    class PieBaker : IPastryFactory<Pastry, Pie>
    {
        
        public PieBaker()
        {
        }

        public Pie bake(Pastry pastry, Filling filling) {
            return new Pie(pastry.name, filling.name);
        }
    }
}
