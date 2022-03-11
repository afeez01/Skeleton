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
    }
}