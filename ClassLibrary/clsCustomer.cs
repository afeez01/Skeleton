using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data customer for the customer id
        private Int32 mCustomerID;
        //CustomerID customers
        public Int32 CustomerID 
        {
            get
            {
                //
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }


        //private data member for order process
        private Boolean mOrderProcess;
        //public property for order process
        public bool OrderProcess
        {
            get
            {
                //return the private data
                return mOrderProcess;
            }
            set
            {
                //set the private data
                mOrderProcess = value;
            }
        }


        //private date added data member
        private DateTime mDateOfBirth;
        //public property for date of birth
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }

        //private data member for the email address
        private string mEmailAddress;
        //public property for the email
        public string EmailAddress
        {
            get
            {
                //return the private data
                return mEmailAddress;
            }
            set
            {
                //set the value of the private data member
                mEmailAddress = value;
            }
        }


        //private data member for the email address
        private string mCustomerDetails;
        //public property for the address number
        public string CustomerDetails
        {
            get
            {
                //return the private data
                return mCustomerDetails;
            }
            set
            {
                //set the value of the private data member
                mCustomerDetails = value;
            }
        }




        //private data customer for the customer id
        private decimal mAccountBalance;
        //CustomerID customers
        public decimal AccountBalance
        {
            get
            {
                //
                return mAccountBalance;
            }
            set
            {
                mAccountBalance = value;
            }
        }









        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the address no to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_filterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mCustomerDetails = Convert.ToString(DB.DataTable.Rows[0]["CustomerDetails"]);
                mAccountBalance = Convert.ToDecimal(DB.DataTable.Rows[0]["AccountBalance"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mOrderProcess = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderProcess"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;

            }            }
    }
}