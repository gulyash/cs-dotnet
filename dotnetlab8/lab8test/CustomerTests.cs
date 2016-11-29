using System;
using dotnetlab8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab8test
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void OrderPowderBunTest()
        {
            Bakery bakery = new Bakery();
            Customer customer = new Customer(bakery);
            Assert.IsNull(customer.orderedPowderBun);
            customer.orderPowderBun("testpastry", "testfilling");
            Assert.IsNotNull(customer.orderedPowderBun);      
        }
    }
}
