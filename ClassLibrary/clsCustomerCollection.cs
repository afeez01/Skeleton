using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private customer data for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data memeber ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        //plubic property for ThisAddress

        //plubic property for customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return private data
                return mCustomerList;
            }
            set
            {
                //set private data
                mCustomerList = value;

            }
        }

        public clsCustomerCollection ()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.CustomerDetails = Convert.ToString(DB.DataTable.Rows[Index]["CustomerDetails"]);
                AnCustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnCustomer.AccountBalance = Convert.ToDecimal(DB.DataTable.Rows[Index]["AccountBalance"]);
                AnCustomer.OrderProcess = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderProcess"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }
            
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return private data
                return mThisCustomer;
            }
            set
            {
                //set private data
                mThisCustomer = value;

            }
        }
        
        public int Count
            { 
                get
                {
                return mCustomerList.Count;
            
                }
                set
                {
                    
                }
        }
        public int Add()
        {
            //add new record to the database based on values of thisCustomer
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@CustomerDetails", mThisCustomer.CustomerDetails);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@AccountBalance", mThisCustomer.AccountBalance);
            DB.AddParameter("@OrderProcess", mThisCustomer.OrderProcess);
            //execute the query 
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //add new record to the database based on values of thisCustomer
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerDetails", mThisCustomer.CustomerDetails);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@AccountBalance", mThisCustomer.AccountBalance);
            DB.AddParameter("@OrderProcess", mThisCustomer.OrderProcess);
            //execute the query 
            DB.Execute("sproc_tblCustomer_Update");
        }

        
    }
}