using System;
using System.Collections.Generic;
using System.Linq;
using dotnetlab6.Baking;
using dotnetlab6.Kitchen;

namespace dotnetlab6.Factories
{
    class PowderBunBaker : IPastryFactory<Pastry, PowderBun>
    {
        public PowderBunBaker()
        {
        }
        
        public PowderBun bake(Pastry pastry, Filling fill) {
            return new PowderBun(pastry.name, fill.name);
        }

        public void bakeOvenTray(Pastry pastry, Filling fill)
        {
            int ovenTraySize = 3;
            List<PowderBun> ovenTray = new List<PowderBun>();
            Console.WriteLine("Bun oventray:");
            ovenTray.Add(new PowderBun(pastry.name, fill.name));
            for (int i = 1; i < ovenTraySize; i++)
            {
                ovenTray.Add((PowderBun)ovenTray.ElementAt(0).Clone());
            }
        }
    }
}
