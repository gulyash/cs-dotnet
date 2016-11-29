using System;
using dotnetlab8.Kitchen;
using dotnetlab8.Factories;
using dotnetlab8.Baking;
using Newtonsoft.Json;
using dotnetlab8.Serialization;

namespace dotnetlab8
{
    /// <summary>
    /// This is where all the bakers work and make pastry
    /// </summary>
    public class Bakery
    {
        public Fridge fridge { get; set; }
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

            powderBunBaker = new PowderBunBaker();
            pieBaker = new PieBaker();
            bunBaker = new BunBaker();
            
            fridge = new Fridge();       
        }
    
        public Fridge TestSerializer(ISerializer serializer, string path, Fridge fridge)
        {
            serializer.Serialize(fridge, path);
            Fridge newFridge = serializer.Deserialize(path);
            return newFridge;
            
        }
    }
}