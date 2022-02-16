using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public short CustomerID { get; set; }
        public DateTime DOB { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerDetails { get; set; }
        public decimal AccountBalance { get; set; }
        public bool OrderProcess { get; set; }
    }
}