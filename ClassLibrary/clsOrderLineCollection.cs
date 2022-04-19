using System;
using System.Collections.Generic;

namespace ClassLibrary
{
   
        public class clsOrderLineCollection
        {


            //private data member for the list
            List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
            //private data member thisOrder
            clsOrderLine mThisOrderLine = new clsOrderLine();
            public clsOrderLineCollection()
            {
                //object for data connection
                clsDataConnection DB = new clsDataConnection();
                //execute the stored procedure
                DB.Execute("sproc_tblOrderLine1_SelectAll");
                //populate the array list with the data table
                PopulateArray(DB);
            }

            void PopulateArray(clsDataConnection DB)
            {
                //popluates the array list based on the data table in the parameter DB
                //var for the index
                Int32 Index = 0;
                //var to store the record count
                Int32 RecordCount;
                //get the count of records
                RecordCount = DB.Count;
                //clear the private array list
                mOrderLineList = new List<clsOrderLine>();

                //while there are records to process
                while (Index < RecordCount)
                {
                    //create a blank order
                    clsOrderLine AnOrderLine = new clsOrderLine();

                    //read in the fields from the current record

                    AnOrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                    AnOrderLine.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                    AnOrderLine.ToolID = Convert.ToInt32(DB.DataTable.Rows[Index]["ToolID"]);
                    AnOrderLine.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                    AnOrderLine.OrderLineDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderLineDate"]);
                    AnOrderLine.OrderLineConfirmed = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderLineConfirmed"]);
                    //add the record to the private data memeber
                    mOrderLineList.Add(AnOrderLine);
                    //point at the next record
                    Index++;


                }
            }
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                //return the private data
                return mOrderLineList;
            }

            set
            {
                //set the private data
                mOrderLineList = value;

            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderLineList.Count;
            }
            set
            {
                //worry about this later

            }
        }
        //public property for ThisOrder
        public clsOrderLine ThisOrderLine
        {
            get
            {
                //return the private data
                return mThisOrderLine;
            }
            set
            {
                //set the private data    
                mThisOrderLine = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database on the values of mThisOrder
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@ToolID", mThisOrderLine.ToolID);
            DB.AddParameter("@Description", mThisOrderLine.Description);
            DB.AddParameter("@OrderLineDate", mThisOrderLine.OrderLineDate);
            DB.AddParameter("@OrderLineConfirmed", mThisOrderLine.OrderLineConfirmed);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrderLine1_Insert");
        }

        public void Update()
        {
            //update an existi9ng record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@ToolID", mThisOrderLine.ToolID);
            DB.AddParameter("@Description", mThisOrderLine.Description);
            DB.AddParameter("@OrderLineDate", mThisOrderLine.OrderLineDate);
            DB.AddParameter("@OrderLineConfirmed", mThisOrderLine.OrderLineConfirmed);

            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine1_Update");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine1_Delete");

        }

        public void ReportByDescription(string Description)
        {
            //filters the records based on a full or partial shipping address
            //conncect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@Description", Description);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine1_FilterByDescription");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}


  
