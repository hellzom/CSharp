// See https://aka.ms/new-console-template for more information
namespace Interface
{
    class Order
    {
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
        //public Order(DateTime datePlaced, float totalPrice)
        //{
        //    TotalPrice = totalPrice;
        //    DatePlaced = datePlaced;
        //}
        public Shipment Shipment {  get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}
