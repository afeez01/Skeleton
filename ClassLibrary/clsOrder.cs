using System;

namespace ClassLibrary
{
    public class clsOrder
    {  
        //OrderId private member variable
        private Int32 mOrderId;      
       
        //OrderId public property
        public Int32 OrderId
        { 
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value; 
            
            
            }
        }
        //CustomerId private member variable
        private Int32 mCustomerId;
        
        //CustomerId public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;

            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }


        //ShippingAddress private member variable
        private string mShippingAddress;
        //ShippingAddress public property
        public string ShippingAddress 
        {
            get
            {
                //this line of code sends data out of the property
                return mShippingAddress;
            }
            set
            {
                //this line of code allows data into the property     
                mShippingAddress = value; 
        }
        }
        //OrderDate private member variable
        private DateTime mOrderDate;
        //OrderDate public property
        public DateTime OrderDate 
        { 
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property 
                mOrderDate = value; 
            }
            }
        //OrderDate private member variable
        private string mOrderEmail;
        //OrderDate public property
        public string OrderEmail 
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderEmail;
                
            }
            set
            {
              //this line of code allows data into the property 
                mOrderEmail = value;
                ;
            }
        }
        //
        private bool mOrderCompleted;
        public bool OrderCompleted 
        { 
            get
            {
                //this line of code sends data out of the property
                return mOrderCompleted;
            }
            set
           {
                //this line of code allows data into the property 
                mOrderCompleted = value; 
        }
            }
        public bool Find(int OrderId)
        {
            //set the private data members to the test data value
            mOrderId = 21;
            mCustomerId = 24;
            mShippingAddress = "Test Shipping address";
            mOrderDate = Convert.ToDateTime("17/08/2020");
            mOrderEmail = "Test Order email";
            mOrderCompleted = true;

            //always return true
            return true;
        }
    }
}