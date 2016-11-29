using System;
using dotnetlab8.Baking;
using dotnetlab8.Factories;
using dotnetlab8.Kitchen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab8test
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void bakeTest()
        {
            PieBaker pieBaker = new PieBaker();
            Pie pie = pieBaker.bake(new Pastry("testpastry"), new Filling("testfilling"));
            Assert.AreEqual(pie.filling.name, "testfilling");
            Assert.AreEqual(pie.pastry.name, "testpastry");

        }

        [TestMethod]
        public void bakeOvenTrayTest()
        {
            PowderBunBaker pbBaker = new PowderBunBaker();
            pbBaker.bakeOvenTray(new Pastry("testpastry"), new Filling("testfilling"));
            Assert.AreEqual(pbBaker.ovenTraySize, 3);
            //Assert.AreEqual(pie.pastry.name, "testpastry");
        }

        [TestMethod]
        public void bunBakerTest()
        {
            BunBaker bunBaker = new BunBaker();
            Bun bun = bunBaker.bake(new Pastry("testpastry"), new Filling("testfilling"));
            Assert.AreEqual(bun.filling.name, "testfilling");
            Assert.AreEqual(bun.pastry.name, "testpastry");
            
            BunBaker bBaker = new BunBaker();
            bBaker.bakeOvenTray(new Pastry("testpastry"), new Filling("testfilling"));
            Assert.AreEqual(bBaker.ovenTraySize, 3);
            //Assert.AreEqual(pie.pastry.name, "testpastry");
        }
    }
}
