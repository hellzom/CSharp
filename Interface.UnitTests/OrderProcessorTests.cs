using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Interface.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {

        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(IShippingCalculator);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
