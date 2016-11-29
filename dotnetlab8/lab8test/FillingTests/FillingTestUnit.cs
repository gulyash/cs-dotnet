using System;
using dotnetlab8.Kitchen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab8test
{
    [TestClass]
    public class FillingTestUnit
    {
        [TestMethod]
        public void CompareToSameFilling_ReturnsZero()
        {
            Filling fill1 = new Filling("texttext");
            Filling fill2 = new Filling("texttext");
            Assert.AreEqual(0, fill1.CompareTo(fill2));
        }
    }
}
