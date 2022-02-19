using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderEmail { get; set; }
        public bool OrderCompleted { get; set; }
    }
}