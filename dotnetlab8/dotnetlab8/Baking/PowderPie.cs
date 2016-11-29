using System;
using dotnetlab8.Kitchen;

namespace dotnetlab8.Baking
{
    public class PowderPie : Pie
    {
        Powder powder;

        public PowderPie(string past, string fill) : base(past, fill)
        {
            powder = new Powder("sugar");
            Console.WriteLine("This pie is with {0} powder!", powder.name);
        }

        public PowderPie(string past, string fill, int w) : base(past, fill, w)
        {
            powder = new Powder("sugar");
            Console.WriteLine("This pie is with {0} powder!", powder.name);
        }

        public override object Clone()
        {
            Console.WriteLine("This one's cloned:");
            return new PowderPie(pastry.name, filling.name);
        }
    }
}
