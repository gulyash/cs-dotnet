using System;
using System.Collections.Generic;
using System.Linq;
using dotnetlab8.Baking;
using dotnetlab8.Kitchen;

namespace dotnetlab8.Factories
{
    public class BunBaker : IPastryFactory<Pastry, Bun>
    {
        public int ovenTraySize;
        public BunBaker()
        {
        }
        
        public Bun bake(Pastry pastry, Filling fill) {
            return new Bun(pastry.name, fill.name);
        }

        public void bakeOvenTray(Pastry pastry, Filling fill)
        {
            ovenTraySize = 3;
            List<Bun> ovenTray = new List<Bun>();
            Console.WriteLine("Bun oventray:");
            ovenTray.Add(new Bun(pastry.name, fill.name));
            for (int i=1; i<ovenTraySize; i++) {
                ovenTray.Add((Bun)ovenTray.ElementAt(0).Clone());
            }
        }
    }
}
