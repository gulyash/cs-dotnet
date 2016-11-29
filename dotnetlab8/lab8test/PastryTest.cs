using System;
using dotnetlab8.Kitchen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab8test
{
    [TestClass]
    public class PastryTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Pastry pastry = new Pastry("testo");
            string str = pastry.name;
            Assert.AreEqual(pastry.name, "testo");
        }
    }
}
