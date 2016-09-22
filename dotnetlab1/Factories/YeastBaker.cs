using System;
using System.Collections.Generic;

namespace dotnetlab1
{
    class YeastBaker: IBaker
    {
        private string pastry;
        private Bakery workplace;

        public YeastBaker(Bakery bakery)
        {
            workplace = bakery;
            pastry = "yeast";
            Console.WriteLine("You just hired {0} baker.", pastry);
        }

        public Bun bakeBun(string filling){
            if (workplace.fridge.hasFilling(filling))
            {
                return new Bun(pastry, filling);
            }
            else
            {
                Console.WriteLine("There's no {0} filling in the bakery fridge.", filling);
                return null;
            }
        }

        public Pie bakePie(string filling)
        {
            if (workplace.fridge.hasFilling(filling))
            {
                return new Pie(pastry, filling);
            }
            else
            {
                Console.WriteLine("There's no {0} filling in the bakery fridge.", filling);
                return null;
            }
        }
    }
}
