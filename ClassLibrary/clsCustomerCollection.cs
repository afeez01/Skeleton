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