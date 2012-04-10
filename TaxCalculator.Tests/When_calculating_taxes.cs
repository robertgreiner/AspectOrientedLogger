using System;
using NUnit.Framework;
using Ninject;
using TaxCalculator.Common;

namespace TaxCalculator.Tests
{
    [TestFixture]
    public class When_calculating_taxes
    {
        private ITaxType salesTax;

        [SetUp]
        public void SetUp()
        {
            var kernel = new StandardKernel(new AppModule());
            salesTax = kernel.Get<ITaxType>();  
        }

        [Test]
        public void Should_intercept_method()
        {
            var total = salesTax.Calculate(100.00m);
            Assert.AreEqual(108.25m, total);
        }

        [Test]
        [ExpectedException(typeof(NotImplementedException))]
        public void Should_throw_error()
        {
            salesTax.ErrorMethod();
        }
    }
}
