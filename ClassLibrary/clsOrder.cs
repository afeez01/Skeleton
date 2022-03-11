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

        //OrderEmail private member variable
        private string mOrderEmail;
        //OrderEmail public property
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
        //OrderCompleted private member variable
        private bool mOrderCompleted;
        //OrderCompleted public property
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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found 
            if (DB.Count == 1 )
            {
                //copy the data from the database to the private data members
            mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]);
            mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
            mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
            mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
            mOrderEmail = Convert.ToString(DB.DataTable.Rows[0]["OrderEmail"]);
            mOrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderCompleted"]);

            //return that everything worked OK 
            return true;
        }
            //if no record was found
            else
            {
                //return false indicating a problem
            return false;
            }
        }
    }
}



