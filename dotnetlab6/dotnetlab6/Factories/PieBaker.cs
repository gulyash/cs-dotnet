using System;
using dotnetlab6.Baking;
using dotnetlab6.Kitchen;

namespace dotnetlab6.Factories
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
