﻿using System;
using System.Collections.Generic;
using System.Linq;
using dotnetlab3.Baking;
using dotnetlab3.Kitchen;

namespace dotnetlab3.Factories
{
    class PowderBunBaker : IPastryFactory<Pastry, PowderBun>
    {
        public PowderBunBaker()
        {
            Console.WriteLine("PowderBunBaker added");
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
