﻿using System;
using System.Collections.Generic;
using System.Collections;
using dotnetlab2.Kitchen;
using dotnetlab2;
using dotnetlab2.Factories;
using dotnetlab2.Baking;

namespace dotnetlab2
{
    /// <summary>
    /// This is where all the bakers work and make pastry
    /// This class supports ICollection interface
    /// </summary>
    class Bakery
    {
        public Fridge fridge;
        
        /// <summary>
        /// like when you open a bakery
        /// </summary>
        public Bakery()
        {
            Console.WriteLine("Bakery opened!");

            fridge = new Fridge();
            //using yield return in fridge class
            fridge.checkFridge();

            PowderBunBaker powderBunBaker = new PowderBunBaker();
            powderBunBaker.bakeOvenTray(new Pastry("puff"), new Filling("caramel"));

            
            //covariance fun
            IPastryFactory<Pastry, Bun> bunBaker = new BunBaker();
            bunBaker.bake(new Pastry("yeast"), new Filling("yoghurt"));
            //the following won't work 
            //powderBunBaker = bunBaker;
            bunBaker = powderBunBaker;
            if (fridge.hasFilling("yoghurt")) bunBaker.bake(new Pastry("yeast"), new Filling("yoghurt"));
            
            
        }
    }
}