using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
 
       
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
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
            mOrderList = new List<clsOrder>(); 
            
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();

                //read in the fields from the current record
                
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.OrderEmail = Convert.ToString(DB.DataTable.Rows[Index]["OrderEmail"]);
                AnOrder.OrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderCompleted"]);
                //add the record to the private data memeber
                mOrderList.Add(AnOrder);
                //point at the next record
                Index ++;

          
        }
            }
        

        public List<clsOrder> OrderList
        { 
            get
            {  
                //return the private data
                return mOrderList;
            }
                
            set
            {
                //set the private data
                mOrderList = value;

            }
        }
        public int Count 
        { 
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
               //worry about this later
               
        }
    }
    //public property for ThisOrder
    public clsOrder ThisOrder 
        {
            get
            {
               //return the private data
                return mThisOrder;
            }
            set
            {
               //set the private data    
                    mThisOrder = value; 
        }
    }

        public int Add()
        {
            //adds a new record to the database on the values of mThisOrder
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderEmail", mThisOrder.OrderEmail);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderCompleted", mThisOrder.OrderCompleted);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existi9ng record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderEmail", mThisOrder.OrderEmail);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderCompleted", mThisOrder.OrderCompleted);

            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");

        }

        public void ReportByShippingAddress(string ShippingAddress)
        {
            //filters the records based on a full or partial shipping address
            //conncect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByShippingAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}