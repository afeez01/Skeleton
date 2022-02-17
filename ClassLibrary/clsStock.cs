using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int ToolID { get; set; }
        public string ToolName { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal UnitPrice { get; set; }
        public bool OnSale { get; set; }
    }
}