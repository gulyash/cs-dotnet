using dotnetlab1.Baking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1.Factories
{
    class YeastBaker: IBaker
    {
        private string pastry;
        
        public YeastBaker()
        {
            pastry = "yeast";
            Console.WriteLine("You just hired {0} baker.", pastry);
        }

        public Bun bakeBun(string filling){
            return new Bun(pastry, filling);
        }

        public Pie bakePie(string filling)
        {
            return new Pie(pastry, filling);
        }
    }
}
