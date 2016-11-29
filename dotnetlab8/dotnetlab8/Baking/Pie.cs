using System;
using dotnetlab8.Kitchen;

namespace dotnetlab8.Baking
{
    public class Pie : AbstractBaking
    {
        public Pie(string past, string fill)
        {
            weight = 800;
            pastry = new Pastry(past);
            filling = new Filling(fill);
            //Console.WriteLine("A whole {0} g. of tasty PIE made of {1} with delicious {2} filling appeared.", weight, pastry.name, filling.name);
        }

        /// <summary>
        /// constructor for a pie where you can specify its weight
        /// </summary>
        /// <param name="past">pie pastry</param>
        /// <param name="fill">pie filling</param>
        /// <param name="w">pie weight</param>
        public Pie(string past, string fill, int w)
        {
            weight = w;
            pastry = new Pastry(past);
            filling = new Filling(fill);
            //Console.WriteLine("A whole {0} g. of tasty PIE made of {1} with delicious {2} filling appeared.", weight, pastry.name, filling.name);
        }


        public override object Clone()
        {
            Console.WriteLine("This one's cloned:");
            return new Pie(pastry.name, filling.name);
        }
    }
}