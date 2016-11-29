using System;
using dotnetlab8.Baking;
using dotnetlab8.Kitchen;

namespace dotnetlab8.Factories
{
    
    public class PieBaker : IPastryFactory<Pastry, Pie>
    {
        
        public PieBaker()
        {
        }

        public Pie bake(Pastry pastry, Filling filling) {
            return new Pie(pastry.name, filling.name);
        }
    }
}
