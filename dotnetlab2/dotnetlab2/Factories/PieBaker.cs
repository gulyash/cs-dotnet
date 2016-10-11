using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetlab2.Baking;
using dotnetlab2.Kitchen;

namespace dotnetlab2.Factories
{
    class PieBaker: IPastryFactory<Pastry, Pie>
    {
        public PieBaker()
        {
            Console.WriteLine("PieBaker");
        }

        public Pie bake(Pastry pastry, Filling filling) {
            return new Pie(pastry.name, filling.name);
        }
    }
}
