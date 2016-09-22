using System;
using System.Collections.Generic;

namespace dotnetlab1
{
    class PuffBaker: IBaker
    {
        private string pastry;
        private Bakery workplace;
        
        public PuffBaker(Bakery bakery)
        {
            workplace = bakery;
            pastry = "puff";
            Console.WriteLine("You just hired {0} baker.", pastry);
        }
        
        public Bun bakeBun(string filling)
        {
            if (workplace.fridge.hasFilling(filling)){
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
