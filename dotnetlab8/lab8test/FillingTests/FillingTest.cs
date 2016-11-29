using System;
using dotnetlab8.Kitchen;
using NUnit.Framework;

namespace lab8test
{
    [TestFixture]
    public class FillingTestNUnit
    {
        [Test]
        public void DefaultConstructorReturnsNotNull()
        {
            Assert.DoesNotThrow(()=> { Filling fill = new Filling(); } );
        }
    }
}
