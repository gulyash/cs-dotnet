using System;
using System.Collections.Generic;
using System.Linq;
using dotnetlab6.Baking;
using dotnetlab6.Kitchen;

namespace dotnetlab6.Factories
{
    class BunBaker : IPastryFactory<Pastry, Bun>
    {
        public BunBaker()
        {
        }
        
        public Bun bake(Pastry pastry, Filling fill) {
            return new Bun(pastry.name, fill.name);
        }

        public void bakeOvenTray(Pastry pastry, Filling fill)
        {
            int ovenTraySize = 3;
            List<Bun> ovenTray = new List<Bun>();
            Console.WriteLine("Bun oventray:");
            ovenTray.Add(new Bun(pastry.name, fill.name));
            for (int i=1; i<ovenTraySize; i++) {
                ovenTray.Add((Bun)ovenTray.ElementAt(0).Clone());
            }
        }
    }
}
