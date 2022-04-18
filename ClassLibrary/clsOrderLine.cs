using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        //OrderId private member variable
        private Int32 mOrderLineID;

        //OrderId public property
        public Int32 OrderLineID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderLineID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderLineID = value;


            }
        }
        //CustomerId private member variable
        private Int32 mOrderID;

        //CustomerId public property
        public Int32 OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;

            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }


        //ShippingAddress private member variable
        private Int32 mToolID;
        //ShippingAddress public property
        public Int32 ToolID
        {
            get
            {
                //this line of code sends data out of the property
                return mToolID;
            }
            set
            {
                //this line of code allows data into the property     
                mToolID = value;
            }
        }
        //OrderDate private member variable
        private Int32 mQuantity;
        //OrderDate public property
        public Int32 Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property 
                mQuantity = value;
            }
        }

        //OrderEmail private member variable
        private Decimal mPrice;
        //OrderEmail public property
        public decimal Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;

            }
            set
            {
                //this line of code allows data into the property 
                mPrice = value;
                
            }
        }
        //OrderCompleted private member variable
        private bool mOrderLineConfirmed;
        //OrderCompleted public property
        public bool OrderLineConfirmed
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderLineConfirmed;
            }
            set
            {
                //this line of code allows data into the property 
                mOrderLineConfirmed = value;
            }
        }
        public bool Find(int OrderLineID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderLineID", OrderLineID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mToolID = Convert.ToInt32(DB.DataTable.Rows[0]["ToolID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mOrderLineConfirmed = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderLineConfirmed"]);

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
