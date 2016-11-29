using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetlab8.Kitchen;

namespace lab8test
{
    [TestClass]
    public class FillingsGeneratorTests
    {
        

        [TestMethod]
        public void Generate_7Fillings_7FillingsReturned()
        {
            FillingsGenerator generator = new FillingsGenerator();

            List<Filling> result = generator.generateFillings(7);

            Assert.AreEqual(7, result.Count);
        }

        [TestMethod]
        public void GenerateFilling_FillingReturned()
        {
            FillingsGenerator generator = new FillingsGenerator();

            Filling fill = generator.generateFilling();

            Assert.IsNotNull(fill);

            Assert.IsTrue(fill.name.Length == 8);
        }
    }
}
