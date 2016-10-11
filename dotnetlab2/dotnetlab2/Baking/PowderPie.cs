using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetlab2.Kitchen;

namespace dotnetlab2.Baking
{
    class PowderPie : Pie
    {
        Powder powder;

        public PowderPie(string past, string fill) : base(past, fill)
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
