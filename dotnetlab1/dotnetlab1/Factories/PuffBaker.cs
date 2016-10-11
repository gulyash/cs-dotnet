using dotnetlab1.Baking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    /// <summary>
    /// This class describes a bakery worker that is a professional with puff pastry
    /// </summary>
    class PuffBaker : IBaker
    {
        private string pastry;
        private Bakery workplace;

        /// <summary>
        /// When you hire a baker
        /// </summary>
        /// <param name="bakery">Baker's workplace</param>
        public PuffBaker(Bakery bakery)
        {
            workplace = bakery;
            pastry = "puff";
            Console.WriteLine("You just hired {0} baker.", pastry);
        }

        /// <summary>
        /// This guy makes you a puff bun with a filling you want
        /// </summary>
        /// <param name="filling">Filling parameter</param>
        /// <returns></returns>
        public Bun bakeBun(string filling)
        {
            if (workplace.fridge.hasFilling(filling))
            return new Bun(pastry, filling);
            else 
            {
                Console.WriteLine("There's no {1} filling in the fridge", filling);
                return null;
            }
        }

        /// <summary>
        /// Baker gives you a pie with a filling you ordered
        /// </summary>
        /// <param name="filling">fill pie with it</param>
        /// <returns></returns>
        public Pie bakePie(string filling)
        {
            if (workplace.fridge.hasFilling(filling)) return new Pie(pastry, filling);
            else {
                Console.WriteLine("There's no {1} filling in the fridge", filling);
                return null;
            }
        }
    }
}
