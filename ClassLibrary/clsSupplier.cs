using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public short SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateAdded { get; set; }
        public bool GlobalSupplier { get; set; }
        public Double Feedback { get; set; }
    }
}