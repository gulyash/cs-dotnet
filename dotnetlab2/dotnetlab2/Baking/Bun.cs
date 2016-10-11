using System;
using dotnetlab2.Kitchen;

namespace dotnetlab2.Baking
{
    class Bun : AbstractBaking
    {

        /// <summary>
        /// constructor for a bun
        /// </summary>
        /// <param name="pastry">bun pastry</param>
        /// <param name="filling">bun filling</param>
        public Bun(string past, string fill)
        {
            weight = 300;
            pastry = new Pastry(past);
            filling = new Filling(fill);
            Console.WriteLine("About {0} g. of tasty BUN made of {1} with delicious {2} filling appeared.", weight, pastry.name, filling.name);
        }

        public override object Clone()
        {
            Console.WriteLine("This one's cloned:");
            return new Bun(pastry.name, filling.name);
        }

    }
}