using System;
using dotnetlab2.Kitchen;

namespace dotnetlab2.Baking
{
    class Pie : AbstractBaking
    {
        public Pie(string past, string fill)
        {
            weight = 800;
            pastry = new Pastry(past);
            filling = new Filling(fill);
            Console.WriteLine("A whole {0} g. of tasty PIE made of {1} with delicious {2} filling appeared.", weight, pastry.name, filling.name);
        }

        public override object Clone()
        {
            Console.WriteLine("This one's cloned:");
            return new Pie(pastry.name, filling.name);
        }
    }
}