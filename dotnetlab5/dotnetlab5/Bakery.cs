using System;
using dotnetlab5.Kitchen;
using dotnetlab5.Factories;
using dotnetlab5.Baking;

namespace dotnetlab5
{
    /// <summary>
    /// This is where all the bakers work and make pastry
    /// </summary>
    class Bakery
    {
        public Fridge fridge;
        public PowderBunBaker powderBunBaker;
        public IPastryFactory<Pastry, Bun> bunBaker;
        public IPastryFactory<Pastry, Pie> pieBaker;
        private Logger<Bakery> logger;

        /// <summary>
        /// it happens when you open a bakery
        /// </summary>
        public Bakery(Logger<Bakery> logger = null)
        {
            this.logger = logger;
            if (logger != null)
                logger.Log("Bakery opened!");

            fridge = new Fridge();
            if (logger != null)
                logger.Log("Fridge is ready.");
            /*
            //using yield return in fridge class
            fridge.checkFridge();
            */
            powderBunBaker = new PowderBunBaker();
            if (logger != null)
                logger.Log("PowderBunBaker added.");
            //if (fridge.hasFilling("caramel")) powderBunBaker.bakeOvenTray(new Pastry("puff"), new Filling("caramel"));

            bunBaker = new BunBaker();
            if (logger != null)
                logger.Log("BunBaker added.");
            //covariance fun
            //if (fridge.hasFilling("yoghurt"))  bunBaker.bake(new Pastry("yeast"), new Filling("yoghurt"));
            //the following won't work 
            //powderBunBaker = bunBaker;

            //the following 2 lines make bunBaker create buns with powder
            //bunBaker = powderBunBaker;
            //if (fridge.hasFilling("yoghurt")) bunBaker.bake(new Pastry("yeast"), new Filling("yoghurt"));     

            pieBaker = new PieBaker();
            if (logger != null)
                logger.Log("PieBaker added.");
        }
    }
}