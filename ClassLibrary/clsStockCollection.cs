using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        // private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        // private data member thisStock
        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {
            // var for the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount = 0;
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblTool_SelectAll");
            // get count of records
            RecordCount = DB.Count;

            // while there are records to process do
            while (Index < RecordCount)
            {
                //create instance of Sock class
                clsStock AnStock = new clsStock();

                // read in the fields from the current record
                AnStock.ToolID = Convert.ToInt32(DB.DataTable.Rows[Index]["ToolID"]);
                AnStock.ToolName = Convert.ToString(DB.DataTable.Rows[Index]["ToolName"]);
                AnStock.QuantityInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityInStock"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.UnitPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["UnitPrice"]);
                AnStock.OnSale = Convert.ToBoolean(DB.DataTable.Rows[Index]["OnSale"]);

                // add the record to the private data member
                mStockList.Add(AnStock);

                // point at the next rexord
                Index++;
            }

            /*//create the item of test data
            clsStock TestItem = new clsStock();

            // set its properties
            TestItem.ToolID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OnSale = false;
            TestItem.QuantityInStock = 7;
            TestItem.ToolName = "Bosch HSS-R Drill Bit";
            TestItem.UnitPrice = 1.9500m;
            // add item to the test list
            mStockList.Add(TestItem);

            // reinitialise the object for some new data
            TestItem = new clsStock();

            // set its properties
            TestItem.ToolID = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OnSale = true;
            TestItem.QuantityInStock = 2;
            TestItem.ToolName = "Bahco 244 Super Sharp Hard Point Hand Saw";
            TestItem.UnitPrice = 6.9500m;
            // add item to the test list
            mStockList.Add(TestItem);*/

        }

        public List<clsStock> StockList 
        { 
            get
            {
                // return the private data
                return mStockList;
            }
            set
            {
                // set the private data
                mStockList = value;

            }
        }

        public int Count
        {
            get
            {
                // return the private data
                return mStockList.Count;
            }
            set
            {
                // set the private data
               

            }
        }

        public clsStock ThisStock 
        { 
            get
            {
                // return the private data
                return mThisStock;
            }
            set
            {
                // set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            // adds a new record to the database based on the values of mThisStock
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the stored procedure           
            DB.AddParameter("@ToolName", mThisStock.ToolName);
            DB.AddParameter("@QuantityInStock", mThisStock.QuantityInStock);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@UnitPrice", mThisStock.UnitPrice);
            DB.AddParameter("@OnSale", mThisStock.OnSale);

            // execute the query returning the primary key value
            return DB.Execute("sproc_tblTool_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of mThisStock
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the stored procedure
            DB.AddParameter("@ToolID", mThisStock.ToolID);
            DB.AddParameter("@ToolName", mThisStock.ToolName);
            DB.AddParameter("@QuantityInStock", mThisStock.QuantityInStock);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@UnitPrice", mThisStock.UnitPrice);
            DB.AddParameter("@OnSale", mThisStock.OnSale);

            // execute the query returning the primary key value
            DB.Execute("sproc_tblTool_Update");
        }

        public void Delete()
        {
            // delete the record pointed by  mThisStock
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the stored procedure
            DB.AddParameter("@ToolID", mThisStock.ToolID);

            // execute the query returning the primary key value
            DB.Execute("sproc_tblTool_Delete");
        }
    }
}