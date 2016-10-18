using System;
using dotnetlab3.Kitchen;

namespace dotnetlab3.Baking
{
    class PowderBun : Bun
    {
        Powder powder;

        public PowderBun(string past, string fill) : base(past, fill)
        {
            powder = new Powder("sugar");
            Console.WriteLine("This bun is with {0} powder!", powder.name);
        }

        public PowderBun(string past, string fill, int w):base(past, fill, w)
        {
            powder = new Powder("sugar");
            Console.WriteLine("This bun is with {0} powder!", powder.name);
        }

        public override object Clone()
        {
            Console.WriteLine("This one's cloned:");
            return new PowderBun(pastry.name, filling.name);
        }
    }
}
