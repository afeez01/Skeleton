using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        //OrderLineID private member variable
        private Int32 mOrderLineID;

        //OrderLineID public property
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
        //OrderID private member variable
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


        //ToolID private member variable
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
        //Description private member variable
        private string mDescription;
        //OrderDate public property
        public string Description
        {
            get
            {
                //this line of code sends data out of the property
                return mDescription;
            }
            set
            {
                //this line of code allows data into the property 
                mDescription = value;
            }
        }

        //OrderLineDate private member variable
        private DateTime mOrderLineDate;
        //OrderEmail public property
        public DateTime OrderLineDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderLineDate;

            }
            set
            {
                //this line of code allows data into the property 
                mOrderLineDate = value;
                
            }
        }
        //OrderLineConfirmed private member variable
        private bool mOrderLineConfirmed;
        //OrderLineConfirmed public property
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
            DB.Execute("sproc_tblOrderLine1_FilterByOrderLineID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mToolID = Convert.ToInt32(DB.DataTable.Rows[0]["ToolID"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mOrderLineDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderLineDate"]); 
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

        public string Valid(string description, string orderLineDate)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary varianle to store date values
            DateTime DateTemp;

            //if the escription is blank
            if (description.Length == 0)
            {
                // record the error
                Error = Error + "The description may not be blank : ";
            }
            //if the escription is greater than 50
            if (description.Length > 50)
            {
                // record the error
                Error = Error + "The description must be less than 50 characters : ";
            }

            try
            {

                //copy the orderLineDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderLineDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The order line date cannot be in the past :";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record error
                    Error = Error + "The order line date cannot be in the future :";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The order line date was not a valid date : ";
            }
            //return any error messages
            return Error;
        }
    }
    }

