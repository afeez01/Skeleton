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
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            PopulateArray(DB);
            
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

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerDetails(string CustomerDetails)
        {
            //filter
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerDetails", CustomerDetails);
            DB.Execute("sproc_tblCustomer_FilteredByCustomerDetails");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnCustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnCustomer.CustomerDetails = Convert.ToString(DB.DataTable.Rows[Index]["CustomerDetails"]);
                AnCustomer.AccountBalance = Convert.ToDecimal(DB.DataTable.Rows[Index]["AccountBalance"]);
                AnCustomer.OrderProcess = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderProcess"]);
                //add record to private dat customers
                mCustomerList.Add(AnCustomer);
                //point at next record
                Index++;
            }

        }
    }
}