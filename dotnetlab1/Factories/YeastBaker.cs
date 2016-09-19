using System;
using System.Collections.Generic;

namespace dotnetlab1
{
    /// <summary>
    /// This class describes a worker that is professional with yeast pastry
    /// </summary>
    class YeastBaker: IBaker
    {
        private string pastry;
        private Bakery workplace;

        /// <summary>
        /// when you hire him
        /// </summary>
        /// <param name="bakery">this is his worklace</param>
        public YeastBaker(Bakery bakery)
        {
            workplace = bakery;
            pastry = "yeast";
            Console.WriteLine("You just hired {0} baker.", pastry);
        }

        /// <summary>
        /// he makes a bun
        /// </summary>
        /// <param name="filling">a bun with this filling</param>
        /// <returns>a bun or null if there is no such filling</returns>
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

        /// <summary>
        /// he makes a pie
        /// </summary>
        /// <param name="filling">a pie with this filling</param>
        /// <returns>a pie if there is such filling in the fridge</returns>
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
