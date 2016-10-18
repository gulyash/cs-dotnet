using System;
using dotnetlab3.Kitchen;
using dotnetlab3.Factories;
using dotnetlab3.Baking;

namespace dotnetlab3
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
        /// <summary>
        /// it happens when you open a bakery
        /// </summary>
        public Bakery()
        {
            Console.WriteLine("Bakery opened!");

            fridge = new Fridge();
            //using yield return in fridge class
            //fridge.checkFridge();

            powderBunBaker = new PowderBunBaker();
            //if (fridge.hasFilling("caramel")) powderBunBaker.bakeOvenTray(new Pastry("puff"), new Filling("caramel"));

            //covariance fun
            bunBaker = new BunBaker();
            //if (fridge.hasFilling("yoghurt"))  bunBaker.bake(new Pastry("yeast"), new Filling("yoghurt"));
            //the following won't work 
            //powderBunBaker = bunBaker;

            //the following 2 lines make bunBaker create buns with powder
            //bunBaker = powderBunBaker;
            //if (fridge.hasFilling("yoghurt")) bunBaker.bake(new Pastry("yeast"), new Filling("yoghurt"));     

            pieBaker = new PieBaker();       
        }
    }
}