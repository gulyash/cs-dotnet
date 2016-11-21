using System;
using dotnetlab6.Kitchen;
using dotnetlab6.Factories;
using dotnetlab6.Baking;
using Newtonsoft.Json;
using dotnetlab6.Serialization;

namespace dotnetlab6
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

            powderBunBaker = new PowderBunBaker();
            if (logger != null)
                logger.Log("PowderBunBaker added.");

            pieBaker = new PieBaker();
            if (logger != null)
                logger.Log("PieBaker added.");

            bunBaker = new BunBaker();
            if (logger != null)
                logger.Log("BunBaker added.");

            fridge = new Fridge();
            fridge.FillFridge();
            if (logger != null)
                logger.Log("Fridge is ready.");
            
            //JsonSerialization
            var jsonSerializator = new SerializerJSON();
            TestSerializer(jsonSerializator, "bat.json", fridge);
          
            //XmlSerialization
            var xmlSerializer = new SerializerXML();
            TestSerializer(xmlSerializer, "bat.xml", fridge);
          
          //BinarySerialization
          var binarySerializator = new SerializerBinary();
          TestSerializer(binarySerializator, "bat.bin", fridge);
        }

        private static void TestSerializer(ISerializer serializer, string path, Fridge fridge)
        {
            serializer.Serialize(fridge, path);
            Fridge newFridge = serializer.Deserialize(path);
            newFridge.checkFridge();
            Console.WriteLine("");
        }
    }
}