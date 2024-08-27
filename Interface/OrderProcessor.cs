// See https://aka.ms/new-console-template for more information
namespace Interface
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            //_shippingCalculator = new ShippingCalculator();
            _shippingCalculator = shippingCalculator; //using interface change in the constructor parameters and then use it here instead of creating an object of the class.
        }
        public void Process(Order order)
        {
            if (order.IsShipped) //defensive programming
                throw new InvalidOperationException("This order is already processed");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
