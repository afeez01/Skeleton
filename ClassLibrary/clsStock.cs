using System;

namespace ClassLibrary
{
    public class clsStock
    {
        // private data member for the tool id property
        private Int32 mToolID;

        public Int32 ToolID 
        {
            get
            {
                // this line of code sends data out of the property
                return mToolID;
            }
            
            set
            {
                // this line of code allows data into the property
                mToolID = value;

            }
        }

        // private data member for the tool name property 
        private string mToolName;
        public string ToolName
        { 
            get
            {
                // return private data
                return mToolName;

            }
            set
            {
                // Set the private data
                mToolName = value;

            }
        }

        // private data member for the QuantityInStock property 
        private Int32 mQuantityInStock;
        public int QuantityInStock 
        { 
            get
            {
                return mQuantityInStock;
            }
            set
            {
                mQuantityInStock = value;
            }
        }

        // private data member for the DateAdded property
        private DateTime mDateAdded;
        public DateTime DateAdded 
        { 
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        // private data member for the UnitPrice property
        private Decimal mUnitPrice;
        public decimal UnitPrice 
        { 
            get
            {
                return mUnitPrice;
            }
            set
            {
                mUnitPrice = value;
            }
        }

        // private data member for the UnitPrice property
        private Boolean mOnSale;
        public bool OnSale 
        { 
            get
            {
                return mOnSale;
            }
            set
            {
                mOnSale = value;
            }
        }

        public bool Find(int ToolID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // add the parameter for the tool id to search for
            DB.AddParameter("@ToolID", ToolID);

            // execute the stored procedure
            DB.Execute("sproc_tblTool_FilterByToolID");

            // if one record is found (there should be either one or zero!)
            if(DB.Count==1)
            {
                // copy the data from the database to the private data members
                mToolID = Convert.ToInt32(DB.DataTable.Rows[0]["ToolID"]);
                mToolName = Convert.ToString(DB.DataTable.Rows[0]["ToolName"]);
                mQuantityInStock = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityInStock"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mUnitPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["UnitPrice"]);
                mOnSale = Convert.ToBoolean(DB.DataTable.Rows[0]["OnSale"]);

                // return that everything worked ok
                return true;

            }
            else // if no record was found
            {
                // return false indicating a problem
                return false;
            }

           /* // set the private data members to the test data value
            mToolID = 21;
            mToolName = "Test Tool Name";
            mQuantityInStock = 100;
            mDateAdded = Convert.ToDateTime("15/05/2017");
            mUnitPrice = 100.99m;
            mOnSale = true;*/


            
        }

        public string Valid(string toolName, string quantityInStock, string dateAdded, string unitPrice)
        {
            // string variable to store any error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //***********************************************************************
            // if the toolName is blank
            if (toolName.Length == 0)
            {
                // record the error
                Error = Error + "The tool name may not be blank : ";
            }

            // if the tool name is greater than 50 chars
            if (toolName.Length > 50)
            {
                // record the error
                Error = Error + "The tool name must be less than 50 characters : ";
            }

            //***********************************************************************
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp.Date < DateTime.Now.Date.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp.Date > DateTime.Now.Date.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //***********************************************************************
            try
            {
                int result = Int32.Parse(quantityInStock);
                if (result < 0)
                {
                    // record the error
                    Error = Error + "The quantityInStock cannot be less than zero : ";
                }
            }
            catch (FormatException)
            {
                // record the error 
                Error = Error + "The quantityInStock has invalid format! : ";
            }

            //***********************************************************************
            try
            {
                decimal result = Decimal.Parse(unitPrice);
                if (result < 0)
                {
                    // record the error
                    Error = Error + "The UnitPrice cannot be less than zero : ";
                }
            }
            catch
            {
                // record the error
                Error = Error + "The UnitPrice has invalid format! : ";
            }


            // return any error messages
            return Error;
        }
    }
}