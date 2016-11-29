using System;
using dotnetlab8;
using dotnetlab8.Kitchen;
using dotnetlab8.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab8test
{
    [TestClass]
    public class BakeryTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Bakery bakery = new Bakery(new Logger<Bakery>("log.txt"));
            bakery.fridge.FillFridge(1);
            Assert.IsNotNull(bakery.fridge);
        }

        [TestMethod]
        public void TestSerializerJSONTest()
        {
            Bakery bakery = new Bakery(new Logger<Bakery>("log.txt"));
            bakery.fridge.FillFridge(1);
            Filling fill = bakery.fridge.fillingShelf[0];
            bakery.fridge = bakery.TestSerializer(new SerializerJSON(), "bat.json", bakery.fridge);
            Assert.IsTrue(bakery.fridge.hasFilling(fill.name));
        }

        [TestMethod]
        public void TestSerializerXMLTest()
        {
            Bakery bakery = new Bakery(new Logger<Bakery>("log.txt"));
            bakery.fridge.FillFridge(1);
            Filling fill = bakery.fridge.fillingShelf[0];
            bakery.fridge = bakery.TestSerializer(new SerializerXML(), "bat.xml", bakery.fridge);
            Assert.IsTrue(bakery.fridge.hasFilling(fill.name));
        }

        [TestMethod]
        public void TestSerializerBinaryTest()
        {
            Bakery bakery = new Bakery(new Logger<Bakery>("log.txt"));
            bakery.fridge.FillFridge(1);
            Filling fill = bakery.fridge.fillingShelf[0];
            bakery.fridge = bakery.TestSerializer(new SerializerBinary(), "bat.bin", bakery.fridge);
            Assert.IsTrue(bakery.fridge.hasFilling(fill.name));
        }


    }
}
